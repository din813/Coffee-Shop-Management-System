using System;
using System.Windows.Forms;

namespace Coffee_Shop_Management_System
{
    internal class openFileDialog1
    {
        internal string Filter;
        private string filename;

        public openFileDialog1()
        {
        }

        internal string Filename { get => filename; set => filename = value; }

        internal DialogResult showDialog()
        {
            throw new NotImplementedException();
        }
    }
}