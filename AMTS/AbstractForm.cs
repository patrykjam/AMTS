using System;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace AMTS
{
    public partial class AbstractForm : Form
    {
        protected bool openedWindow = false;
        PrivateFontCollection PFC;
        public void changeOpenedWindow()
        {
            openedWindow = !openedWindow;
        }
        public AbstractForm()
        {
            InitializeComponent();
            PFC = new PrivateFontCollection();
            string fileName = "MyriadPro.ttf";
            string path = Path.Combine(Environment.CurrentDirectory, @"", fileName);
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\Data\" + fileName));
            PFC.AddFontFile(newPath);

        }
    }
}
