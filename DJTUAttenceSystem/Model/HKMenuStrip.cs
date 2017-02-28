using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace DJTUAttenceSystem.Model {
    class HKMenuStrip : ContextMenuStrip {
        public delegate void ItemHandler(string itemText, object userData);
        public class ItemStruct {
            public string name;
            public ItemHandler handler;
            public object userData;
            public ItemStruct() {

            }
            public ItemStruct(string name,ItemHandler handler,object userData) {
                this.name = name;
                this.handler = handler;
                this.userData = userData;
            }
        }
        public ArrayList itemStructs = new ArrayList();
        public static HKMenuStrip createRightMenu(params ItemStruct[] items) {
            HKMenuStrip menu = new HKMenuStrip();
            foreach (ItemStruct item in items) {
                menu.addItem(item);
            }
            return menu;
        }
        public HKMenuStrip() {
            Size = new Size(270, 86);
        }
        public void addItem(ItemStruct item) {
            if (!isNameContainsInMenu(item.name)) {
                ToolStripMenuItem newItem = new ToolStripMenuItem(item.name);
                newItem.Click += item_Click;
                itemStructs.Add(item);
                Items.Add(newItem);
            }
        }
        private void item_Click(object sender, EventArgs e) {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            ItemStruct itemStruct = getItemStruct(item.Text);
            if (itemStruct.handler != null) {
                itemStruct.handler(itemStruct.name, itemStruct.userData);
            }
        }
        private ItemStruct getItemStruct(string name) {
            foreach (ItemStruct item in itemStructs) {
                if (item.name.Equals(name)) {
                    return item;
                }
            }
            return null;
        }
        private bool isNameContainsInMenu(string name) {
            if (getItemStruct(name) != null) {
                return true;
            }else {
                return false;
            }
        }
    }
}
