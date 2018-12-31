using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public object MessageBox { get; private set; }

        private void Button1_Click(object senedr, EventArgs e) {
            MessageBox.Equals("test");
        }
    }
}
