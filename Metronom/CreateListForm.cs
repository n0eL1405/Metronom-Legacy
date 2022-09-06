using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Metronom {

	public partial class CreateListForm : Form {

		public string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Metronom";

		private List list = new List("newList");
		private ArrayList allLists = new ArrayList();

		public CreateListForm() {
			InitializeComponent();
			cBoxLists.DropDown += CBoxListsOnDropDown;
		}

		private void saveList(string listName) {

			var path = documentsPath + "\\Lists";

			if (!Directory.Exists(path)) {
				Directory.CreateDirectory(path);
			}

			var pathWithName = path + "\\" + listName + ".xml";

			if (File.Exists(pathWithName)) {
				var fileExistsMsgBx = MessageBox.Show("File already exists, overwrite?", "Error",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

				if (fileExistsMsgBx == DialogResult.Yes) {
					File.Delete(pathWithName);
				} else {
					return;
				}
			}

			list.setName(listName);

			var sr = new XmlSerializer(list.GetType());
			var listFileStream = new FileStream(pathWithName, FileMode.OpenOrCreate, FileAccess.Write);
			var writer = new StreamWriter(listFileStream);
			sr.Serialize(writer, list);
			writer.Close();
			MessageBox.Show("List saved!", "List saved!", MessageBoxButtons.OK);
		}


		private List addListEntry(List list) {

			try {
				int.Parse(txtBxBPM.Text);
			}
			catch (FormatException) {
				MessageBox.Show("ERROR: \"" + txtBxBPM.Text + "\" is not a valid number!", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return list;
			}

			try {
				int.Parse(txtBxTact.Text);
			}
			catch (FormatException) {
				MessageBox.Show("ERROR: \"" + txtBxTact.Text + "\" is not a valid number!", "ERROR",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return list;
			}

			ListEntry listEntry = new ListEntry(int.Parse(txtBxBPM.Text), int.Parse(txtBxTact.Text), txtBxArtist.Text, txtBxSong.Text);

			list.addListEntry(listEntry);

			currentListEntriesBox.BeginUpdate();
			currentListEntriesBox.Items.Add(listEntry.ToString());
			currentListEntriesBox.EndUpdate();

			return list;
		}

		public void btnAddMethod() {
			list = addListEntry(list);
		}

		public void btnNewMethod() {
			currentListEntriesBox.Items.Clear();
			
			list = new List();
			txtBxName.Text = "";
			txtBxBPM.Text = "";
			txtBxTact.Text = "";
			txtBxArtist.Text = "";
			txtBxSong.Text = "";
		}

		public void btnSaveMethod() {

			if (txtBxName.Text.Equals("")) {
				MessageBox.Show("ERROR: Name can't be empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			
			saveList(txtBxName.Text);
		}

		private void btnAdd_Click(object sender, EventArgs e) {
			btnAddMethod();
		}

		private void btnNew_Click(object sender, EventArgs e) {
			btnNewMethod();
		}

		private void btnSave_Click(object sender, EventArgs e) {
			btnSaveMethod();
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData) {
			if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.A) {
				btnAddMethod();

				return true;
			}

			if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.S) {
				btnSaveMethod();

				return true;
			}

			if ((keyData & Keys.Control) > 0 && (keyData & Keys.KeyCode) == Keys.N) {
				btnNewMethod();

				return true;
			}

			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void CBoxListsOnDropDown(object sender, EventArgs e)
		{
			cBoxLists.Items.Clear();

			foreach (var path in Directory.GetFiles(documentsPath + "\\Lists"))
			{

				var list = new List();

				try
				{

					var xs = new XmlSerializer(typeof(List));
					var read = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
					list = (List)xs.Deserialize(read);
					read.Close();
				}
				catch (DirectoryNotFoundException) { }

				allLists.Add(path);
				cBoxLists.Items.Add(list.getName());
			}
		}

		private void cBoxListsSelectedIndexChanged(object sender, EventArgs e) {
			currentListEntriesBox.Items.Clear();

			var list = new List();
			try
			{

				var xs = new XmlSerializer(typeof(List));
				var read = new FileStream((string) allLists[cBoxLists.SelectedIndex], FileMode.Open, FileAccess.Read, FileShare.Read);
				list = (List)xs.Deserialize(read);
				read.Close();
			}
			catch (DirectoryNotFoundException) { }

			foreach (ListEntry listEntry in list.getListEntries()) {
	            currentListEntriesBox.BeginUpdate();
	            currentListEntriesBox.Items.Add(listEntry.ToString());
	            currentListEntriesBox.EndUpdate();
			}
		}

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
			File.Delete((string)allLists[cBoxLists.SelectedIndex]);
			cBoxLists.Text = "";
        }
    }
}
