﻿using System.Windows.Forms;

namespace GUI {
    public partial class FRegister : Form {
        public FRegister() {
            InitializeComponent();
        }

        private void FRegister_Load(object sender, System.EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 200, WinAPI.BLEND);
        }

        private void btnRegister_Click(object sender, System.EventArgs e) {
            this.Hide();
            (new FLogin()).ShowDialog();
        }
    }
}
