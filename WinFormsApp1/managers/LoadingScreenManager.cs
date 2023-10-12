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

        public static void ShowLoadingScreen(Form f)
        {
            if (loadingForm != null && !loadingForm.IsDisposed)
                return; // Loading form is already shown

            loadingForm = f;

            // Show the form on a separate thread using Task.Run
            Task.Run(() =>
            {
                Application.Run(loadingForm);
            });
        }

        public static void HideLoadingScreen()
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +  ex.Message);
            }
        }
    }
}