namespace Metronom {

	public class ListEntry {

		public string artist = "";

		public int bpm;
		public string song = "";
		public int tact;

		public ListEntry() { }

		public ListEntry(int bpm, int tact, string artist, string song) {
			this.bpm = bpm;
			this.tact = tact;
			this.artist = artist;
			this.song = song;
		}

		public ListEntry(int bpm, int tact) {
			new ListEntry(bpm, tact, null, null);
		}

		public int getBPM() {
			return bpm;
		}

		public int getTact() {
			return tact;
		}

		public string getArtist() {
			return artist;
		}

		public string getSong() {
			return song;
		}

		public void setBPM(int bpm) {
			this.bpm = bpm;
		}

		public void setTact(int bpm) {
			this.bpm = bpm;
		}

		public void setArtist(string artist) {
			this.artist = artist;
		}

		public void setSong(string song) {
			this.song = song;
		}

		override 
		public string ToString() {
			return getBPM() + "/" + getTact() + " (" + getSong() + " - " + getArtist() + ")";
		}

	}

}
