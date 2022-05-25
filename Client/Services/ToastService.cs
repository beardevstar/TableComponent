using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FilterTableComponentSample.Client.Services
{
    public class ToastService : IDisposable
    {
        public event Action<string, ToastLevel,string,string> OnShow;
        public event Action OnHide;
        private Timer Countdown;

        public void ShowToast(string message, ToastLevel level,string _xpos="right",string _ypos="top")
        {
            OnShow?.Invoke(message, level,_xpos,_ypos);
            StartCountdown();
        }

        private void StartCountdown()
        {
            SetCountdown();

            if (Countdown.Enabled)
            {
                Countdown.Stop();
                Countdown.Start();
            }
            else
            {
                Countdown.Start();
            }
        }

        private void SetCountdown()
        {
            if (Countdown == null)
            {
                Countdown = new Timer(5000);
                Countdown.Elapsed += HideToast;
                Countdown.AutoReset = false;
            }
        }

        private void HideToast(object source, ElapsedEventArgs args)
        {
            OnHide?.Invoke();
        }

        public void Dispose()
        {
            Countdown?.Dispose();
        }
    }
}
