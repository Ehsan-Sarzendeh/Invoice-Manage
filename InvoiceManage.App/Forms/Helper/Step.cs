using System.Windows.Forms;

namespace InvoiceManage.App.Forms.Helper
{
    public class Step
    {
        public void Previous(Form parentForm, string currentStep, string previousStep, string previousPageName)
        {
            // resolve images
            var currentPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(currentStep, false)[0];
            currentPictureBox.Image = Properties.Resources.pending;

            var previousPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(previousStep, false)[0];
            previousPictureBox.Image = Properties.Resources.current;

            // resolve pages
            parentForm.Controls.Find("panel", false)[0].Controls.Find("PanelSlider", false)[0].Controls.Find(previousPageName, false)[0].BringToFront();
        }   

        public void Next(Form parentForm, string currentStep, string nextStep, string nextPageName)
        {
            // resolve images 
            var currentPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(currentStep, false)[0];
            currentPictureBox.Image = Properties.Resources.completed;

            var nextPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(nextStep, false)[0];
            nextPictureBox.Image = Properties.Resources.current;

            // resolve pages
            parentForm.Controls.Find("panel", false)[0].Controls.Find("PanelSlider", false)[0].Controls.Find(nextPageName, false)[0].BringToFront();
        }
    }
}
