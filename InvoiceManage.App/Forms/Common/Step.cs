using System.Windows.Forms;

namespace InvoiceManage.App.Forms.Common
{
    public class Step
    {
        public Control Previous(Form parentForm, string currentStep, string previousStep, string previousPageName)
        {
            // resolve images
            var currentPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(currentStep, false)[0];
            currentPictureBox.Image = Properties.Resources.pending;

            var previousPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(previousStep, false)[0];
            previousPictureBox.Image = Properties.Resources.current;

            // resolve pages
            var previousControl = parentForm.Controls.Find("panel", false)[0].Controls.Find("PanelSlider", false)[0].Controls.Find(previousPageName, false)[0];

            previousControl.BringToFront();

            return previousControl;
        }   

        public Control Next(Form parentForm, string currentStep, string nextStep, string nextPageName)
        {
            // resolve images 
            var currentPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(currentStep, false)[0];
            currentPictureBox.Image = Properties.Resources.completed;

            var nextPictureBox = (PictureBox)parentForm.Controls.Find("panel", false)[0].Controls.Find(nextStep, false)[0];
            nextPictureBox.Image = Properties.Resources.current;

            // resolve pages
            var nextControl = parentForm.Controls.Find("panel", false)[0].Controls.Find("PanelSlider", false)[0]
                .Controls.Find(nextPageName, false)[0];

            nextControl.BringToFront();

            return nextControl;
        }
    }

    public enum Mode
    {
        Required = 0,
        SemiRequired = 1,
        Optional = 2,
        Ignore = 3
    }
}
