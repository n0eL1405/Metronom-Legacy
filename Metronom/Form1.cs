using System;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Metronom {
    public partial class MainForm : Form {
        private int bpm;
        private int cntListEntry;
        private int cntTick = 1;
        private int countDownInputMin;
        private int countDownInputSec;

        private readonly CountDownTimer countDownTimer = new CountDownTimer();

        public string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Metronom";

        private int increaseAfterSec;
        private int increaseBy;
        private List list;

        private readonly ArrayList listsList = new ArrayList();
        private bool isPaused = false;

        private readonly short maxLEDs = 11;
        private int maxListEntries = int.MaxValue;

        private SoundPlayer player;
        private int tact;
        private bool isRunning = false;

        public MainForm() {
            InitializeComponent();
            cBoxLists.DropDown += CBoxListsOnDropDown;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
            if ((keyData & Keys.KeyCode) == Keys.Space) {
                if (BPMtimer.Enabled) {
                    stopAll();
                }
                else {
                    start();
                }

                return true;
            }

            if ((keyData & Keys.KeyCode) == Keys.Enter) {
                if (!isRunning) {
                    startList();
                }
                else {
                    btnStartList.Text = "Next";
                    next();
                }

                return true;
            }

            if ((keyData & Keys.KeyCode) == Keys.Up) {
                try {
                    bpm += testForInt(txtBxStep.Text, "ERROR: \"" + txtBxStep.Text + "\" is not a valid number!");

                    txtBxBPM.Text = bpm.ToString();

                    if (isRunning) {
                        start();
                    }
                }
                catch (Exception) {
                    return true;
                }

                return true;
            }

            if ((keyData & Keys.KeyCode) == Keys.Down) {
                try {
                    if (bpm - testForInt(txtBxStep.Text, "ERROR: \"" + txtBxStep.Text + "\" is not a valid number!") >=
                        1) {
                        bpm -= testForInt(txtBxStep.Text, "ERROR: \"" + txtBxStep.Text + "\" is not a valid number!");
                    }
                    else {
                        bpm = 1;
                    }

                    txtBxBPM.Text = bpm.ToString();

                    if (isRunning) {
                        start();
                    }
                }
                catch (Exception) {
                    return true;
                }

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainForm_Load(object sender, EventArgs e) { }

        private void btnStart_Click(object sender, EventArgs e) {
            start();
        }

        private void BPMtimer_Tick(object sender, EventArgs e) {
            if (cntTick == 1) {
                playFirstSound();
                turnOffLED(tact);
                turnOnLED(cntTick);
                cntTick++;
            }
            else if (cntTick == tact) {
                playOtherSound();
                turnOffLED(cntTick - 1);
                turnOnLED(cntTick);
                cntTick = 1;
            }
            else {
                playOtherSound();
                turnOffLED(cntTick - 1);
                turnOnLED(cntTick);
                cntTick++;
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            stopAll();
        }

        private void increaseBpm() {
            try {
                increaseAfterSec = testForInt(txtBxIncreaseAfter.Text,
                    "ERROR: \"" + txtBxIncreaseAfter.Text + "\" is not a valid number!");
            }
            catch (Exception) {
                return;
            }

            increaseBPMtimer.Interval = increaseAfterSec * 1000;
            increaseBPMtimer.Enabled = true;
            increaseBPMtimer.Start();
        }

        private void increaseBPMtimer_Tick(object sender, EventArgs e) {
            try {
                increaseBy = testForInt(txtBxNewTact.Text,
                    "ERROR: \"" + txtBxNewTact.Text + "\" is not a valid number!");
            }
            catch (Exception) {
                return;
            }

            bpm += increaseBy;
            BPMtimer.Interval = 60000 / bpm;
            txtBxBPM.Text = bpm + "";
        }

        private void start() {
            //test that text is not empty
            if (txtBxBPM.Text != "") {
                try {
                    //test that text is a number
                    bpm = testForInt(txtBxBPM.Text, "ERROR: Invalid BPM or tact!");

                    if (bpm <= 0) {
                        MessageBox.Show("ERROR: BPM has to be at leat \"1\"!", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                        return;
                    }

                    //if tact is empty, that tact = 4, if not...
                    if (txtBxTact.Text == "") {
                        tact = 4;
                    }
                    else {
                        //test if tact text is a number and set the tact to this number
                        tact = testForInt(txtBxTact.Text, "ERROR: Invalid BPM or tact!");
                    }
                }
                catch (Exception) {
                    return;
                }

                if (cBxIncreaseBPM.Checked) {
                    increaseBpm();
                }

                countDown();

                for (var i = 1; i <= tact; i++) {
                    activateLED(i);
                }

                BPMtimer.Interval = 60000 / bpm;
                BPMtimer.Enabled = true;
                BPMtimer.Start();
                isRunning = true;
            }
            else {
                MessageBox.Show("ERROR: BPM is empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopAll() {
            BPMtimer.Stop();
            increaseBPMtimer.Stop();
            countDownTimer.Stop();

            for (var i = 1; i <= 15; i++) {
                deactivateLED(i);
            }

            cntTick = 1;
            tact = 4;
            cntListEntry = 0;
            txtBxArtist.Text = "";
            txtBxSong.Text = "";
            btnPauseList.Text = "Pause";
            isPaused = false;
            btnStartList.Text = "Start List";
            isRunning = false;
        }

        private void playFirstSound() {
            try {
                player = new SoundPlayer();
                player.SoundLocation = Environment.CurrentDirectory + "\\first_tick.wav";
                player.Play();
            }
            catch (Exception) {
                MessageBox.Show("ERROR: No soundfile found for first tick,\n" +
                                "please check if there is a \"first_tick.wav\" in the programm directory!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                stopAll();
            }
        }

        private void playOtherSound() {
            try {
                player = new SoundPlayer();
                player.SoundLocation = Environment.CurrentDirectory + "\\other_ticks.wav";
                player.Play();
            }
            catch (Exception) {
                MessageBox.Show("ERROR: No soundfile found for other ticks,\n" +
                                "please check if there is a \"other_ticks.wav\" in the programm directory!", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                stopAll();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e) {
            MessageBox.Show("Use this to stop the metronom after an specifc time.\n" +
                            "\"0\" in both fields means the timer will run infinite",
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void countDown() {
            try {
                countDownInputMin = testForInt(txtBxInputMin.Text, "ERR: Invalid input");
                countDownInputSec = testForInt(txtBxInputSec.Text, "ERR: Invalid input");
            }
            catch (Exception) {
                return;
            }

            if (countDownInputMin == 0 && countDownInputSec != 0 || countDownInputMin != 0 && countDownInputSec == 0 ||
                countDownInputMin != 0 && countDownInputSec != 0) {
                countDownTimer.SetTime(countDownInputMin, countDownInputSec);
                countDownTimer.Start();
                countDownTimer.TimeChanged += () => txtBxCountDownRemain.Text = countDownTimer.TimeLeftMsStr;
                countDownTimer.CountDownFinished += () => pause();
                countDownTimer.StepMs = 77;
            }
        }

        ///////List stuff

        private void btnCreateList_Click(object sender, EventArgs e) {
            var createForm = new CreateListForm();
            createForm.Show();
        }

        private void btnStartList_Click(object sender, EventArgs e) {
            if (!isRunning) {
                startList();
            }
            else {
                btnStartList.Text = "Next";
                next();
            }
        }

        private void startList() {
            /*
                var pathWithName = documentsPath + "\\Lists\\" + cBoxLists.SelectedText;
    
                try {
    
                    var xs = new XmlSerializer(typeof(List));
                    var read = new FileStream(pathWithName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    list = (List) xs.Deserialize(read);
                    read.Close();
                }
                catch (DirectoryNotFoundException) {
                    MessageBox.Show("File not found!", "File not found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                */

            list = (List)listsList[cBoxLists.SelectedIndex];

            maxListEntries = list.listEntries.Count;

            try {
                bpm = list.getListEntry(cntListEntry).getBPM();
                txtBxBPM.Text = list.getListEntry(cntListEntry).getBPM().ToString();
                tact = list.getListEntry(cntListEntry).getTact();
                txtBxTact.Text = list.getListEntry(cntListEntry).getTact().ToString();
                txtBxArtist.Text = list.getListEntry(cntListEntry).getArtist();
                txtBxSong.Text = list.getListEntry(cntListEntry).getSong();
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("No entries in list \"" + list.getName() + "\"", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            start();
            isRunning = true;
            btnStartList.Text = "Next";
        }

        private void next() {
            cntListEntry++;

            if (cntListEntry < maxListEntries) {
                BPMtimer.Stop();
                countDownTimer.Stop();

                for (var i = 1; i <= maxLEDs; i++) {
                    deactivateLED(i);
                }

                cntTick = 1;

                bpm = list.getListEntry(cntListEntry).getBPM();
                txtBxBPM.Text = list.getListEntry(cntListEntry).getBPM().ToString();
                tact = list.getListEntry(cntListEntry).getTact();
                txtBxTact.Text = list.getListEntry(cntListEntry).getTact().ToString();
                txtBxArtist.Text = list.getListEntry(cntListEntry).getArtist();
                txtBxSong.Text = list.getListEntry(cntListEntry).getSong();

                isPaused = false;
                btnPauseList.Text = "Pause";
                start();
            }
            else {
                var stopList = MessageBox.Show("Reached end of List.\nStop List?", "End of List",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (stopList == DialogResult.Yes) {
                    stopAll();
                }
            }
        }

        private void CBoxListsOnDropDown(object sender, EventArgs e) {
            setLists();
        }

        private void setLists() {
            cBoxLists.Items.Clear();

            foreach (var path in Directory.GetFiles(documentsPath + "\\Lists")) {
                var list = new List();

                try {
                    var xs = new XmlSerializer(typeof(List));
                    var read = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                    list = (List)xs.Deserialize(read);
                    read.Close();
                }
                catch (DirectoryNotFoundException) { }

                listsList.Add(list);
                cBoxLists.Items.Add(list.getName());
            }
        }

        private void btnPauseList_Click(object sender, EventArgs e) {
            pause();
        }

        private void pause() {
            if (isPaused) {
                //Resume the List
                start();
                countDownTimer.Start();
                isPaused = false;

                btnPauseList.Text = "Pause";
            }
            else {
                //Pause the list
                BPMtimer.Stop();
                countDownTimer.Stop();
                cntTick = 1;
                isPaused = true;

                btnPauseList.Text = "Resume";
            }
        }

        ///////LED stuff
        public Button getLED(int LEDnumber) {
            var selectedButton = new Button();

            switch (LEDnumber) {
                case 1: {
                    selectedButton = led1;

                    break;
                }

                case 2: {
                    selectedButton = led2;

                    break;
                }

                case 3: {
                    selectedButton = led3;

                    break;
                }

                case 4: {
                    selectedButton = led4;

                    break;
                }

                case 5: {
                    selectedButton = led5;

                    break;
                }

                case 6: {
                    selectedButton = led6;

                    break;
                }

                case 7: {
                    selectedButton = led7;

                    break;
                }

                case 8: {
                    selectedButton = led8;

                    break;
                }

                case 9: {
                    selectedButton = led9;

                    break;
                }

                case 10: {
                    selectedButton = led10;

                    break;
                }

                case 11: {
                    selectedButton = led11;

                    break;
                }
            }

            return selectedButton;
        }

        public void turnOnLED(int LEDnumber) {
            var selectedButton = getLED(LEDnumber);

            if (selectedButton.AccessibleName != null && selectedButton.AccessibleName.Equals("led1")) {
                selectedButton.BackColor = Color.Green;
                selectedButton.FlatAppearance.BorderSize = 1;
            }
            else {
                selectedButton.BackColor = Color.Red;
                selectedButton.FlatAppearance.MouseDownBackColor = Color.Red;
                selectedButton.FlatAppearance.MouseOverBackColor = Color.Red;
                selectedButton.FlatAppearance.BorderSize = 1;
            }

            returnLED(selectedButton, LEDnumber);
        }

        public void turnOffLED(int LEDnumber) {
            var selectedButton = getLED(LEDnumber);
            selectedButton.BackColor = Color.Transparent;
            selectedButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            selectedButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            selectedButton.FlatAppearance.BorderSize = 1;
            returnLED(selectedButton, LEDnumber);
        }

        public void activateLED(int LEDnumber) {
            var selectedButton = getLED(LEDnumber);
            selectedButton.BackColor = Color.Transparent;
            selectedButton.FlatAppearance.BorderSize = 1;
            returnLED(selectedButton, LEDnumber);
        }

        public void deactivateLED(int LEDnumber) {
            var selectedButton = getLED(LEDnumber);
            selectedButton.BackColor = Color.Transparent;
            selectedButton.FlatAppearance.BorderSize = 0;
            returnLED(selectedButton, LEDnumber);
        }

        private void returnLED(Button selectedButton, int LEDnumber) {
            switch (LEDnumber) {
                case 1: {
                    led1 = selectedButton;

                    break;
                }

                case 2: {
                    led2 = selectedButton;

                    break;
                }

                case 3: {
                    led3 = selectedButton;

                    break;
                }

                case 4: {
                    led4 = selectedButton;

                    break;
                }

                case 5: {
                    led5 = selectedButton;

                    break;
                }

                case 6: {
                    led6 = selectedButton;

                    break;
                }

                case 7: {
                    led7 = selectedButton;

                    break;
                }

                case 8: {
                    led8 = selectedButton;

                    break;
                }

                case 9: {
                    led9 = selectedButton;

                    break;
                }

                case 10: {
                    led10 = selectedButton;

                    break;
                }

                case 11: {
                    led11 = selectedButton;

                    break;
                }
            }
        }

        private void btnHelpTwo_Click(object sender, EventArgs e) {
            MessageBox.Show("With Num+ and Num- you increase/decrease the BPM\n" +
                            "by the amount in the text field",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private int testForInt(String text, String errorMessage) {
            int number;
            try {
                number = Int32.Parse(text);
            }
            catch (Exception) {
                MessageBox.Show(errorMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stopAll();
                throw;
            }

            return number;
        }

        private void led11_Click(object sender, EventArgs e) {
            Process.Start("https://youtu.be/dQw4w9WgXcQ");
        }
    }
}