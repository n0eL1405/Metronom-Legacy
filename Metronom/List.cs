using System.Collections;
using System.Xml.Serialization;

namespace Metronom {

	[XmlInclude(typeof(ListEntry))]
	public class List {

		public ArrayList listEntries = new ArrayList();

		public string name;

		public List() { }

		public List(string name) {
			this.name = name;
		}

		public List(string name, ArrayList listEntries) {
			this.name = name;
			this.listEntries = listEntries;
		}

		public string getName() {
			return name;
		}

		public ArrayList getListEntries() {
			return listEntries;
		}

		public ListEntry getListEntry(int listPosition) {
			return (ListEntry) listEntries[listPosition];
		}

		public List getList() {
			return this;
		}

		public void setName(string name) {
			this.name = name;
		}

		public void addListEntry(ListEntry listEntry) {
			listEntries.Add(listEntry);
		}

	}

}
