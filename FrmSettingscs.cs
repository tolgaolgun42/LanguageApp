﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjectForLanguage
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private string connectionString = "Data Source=DESKTOP-DUEUI74;Initial Catalog=LanguageApp;Integrated Security=True;TrustServerCertificate=True";
        public static int QuizQuestionNumber { get; private set; } = 10; // Varsayılan olarak 10 soru

        private void btnConfirmNumber_Click(object sender, EventArgs e)
        {
            // Kullanıcı tarafından girilen soru numarasını al
            string questionNumberText = txtQuestionNumber.Text;
            if (int.TryParse(questionNumberText, out int questionNumber))
            {
                // Geçerli bir sayı girilmişse
                QuizQuestionNumber = questionNumber;
                MessageBox.Show("Soru sayısı başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMainPage mainPage = new FrmMainPage();
            this.Close();
            mainPage.Show();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
