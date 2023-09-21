using System;
using System.Windows.Forms;

namespace Dose_Calculations
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Disclaimer: Medicine Dose Calculator Application\r\n\r\nThe Medicine Dose Calculator is a tool designed to assist in calculating recommended medication doses based on certain input parameters. This application should be used solely as a reference and a convenience, and the calculated results should not be considered as professional medical advice.\r\n\r\nImportant Points to Consider:\r\n- The calculated doses are based on publicly available recommendations and standards. However, the accuracy of the calculations may vary based on factors not considered by the application.\r\n- Users are solely responsible for verifying and cross-referencing the calculated results with healthcare professionals, package inserts, and medical guidelines before administering any medication.\r\n- The application's calculated doses should not replace a medical professional's assessment and prescription.\r\n- Dosing recommendations can change over time and may vary based on individual patient factors. Always consult a healthcare professional before making decisions regarding medication administration.\r\n- The application does not account for specific medical conditions, allergies, contraindications, and potential drug interactions.\r\n\r\nBy using the Medicine Dose Calculator, you acknowledge that you understand and agree to the above terms and limitations. The application's developers, contributors, and affiliated parties are not liable for any errors, inaccuracies, or actions taken based on the application's calculated doses.\r\n\r\nUse this application at your own discretion and consult a healthcare professional for medical advice.\r\n";


            //lblInfo.Text = "**Disclaimer**\r\n\r\n This application provides convenient calculations for medicine doses based on recommended guidelines. " +
            //    "However, it is important to note the following:\r\n\r\n1. " +
            //    "**Use at Your Own Discretion**: This application does not endorse or substitute for professional medical judgment. " +
            //    "Users are solely responsible for interpreting and using the calculated information.\r\n\r\n2." +
            //    " **Variations in Guidelines**: Medical guidelines and recommendations can vary by region and over time. " +
            //    "Users should cross-reference calculations with trusted medical sources.\r\n\r\n3. " +
            //    "**Limitation of Liability**: The developers of this application are not liable for any damages or losses resulting" +
            //    " from the use or misuse of the calculated information. By using this application, " +
            //    "you agree to hold the developers harmless from any claims, damages, or liabilities\r\n\r\n4." +
            //    "**Accuracy Not Guaranteed**: While every effort has been made to ensure accurate calculations, " +
            //    "this application is intended for general informational purposes only. " +
            //    "It may not account for individual patient conditions, medical history, or specific treatment protocols. ";
        }
    }
}
