using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.utilForms;

namespace WinFormsApp1.managers
{
    public static class LoadingScreenManager
    {
        private static Form loadingForm;

        public static void ShowLoadingScreen()
        {
            if (loadingForm != null && !loadingForm.IsDisposed)
                return; // Loading form is already shown

            loadingForm = new Loading();

            // Show the form on a separate thread using Task.Run
            Task.Run(() =>
            {
                Application.Run(loadingForm);
            });
        }

        public static void HideLoadingScreen()
        {
            if (loadingForm != null && !loadingForm.IsDisposed)
            {
                loadingForm.Invoke(new Action(() =>
                {
                    loadingForm.Close();
                    loadingForm.Dispose();
                    loadingForm = null;
                }));
            }
        }
    }
}