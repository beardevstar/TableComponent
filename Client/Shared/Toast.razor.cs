using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilterTableComponentSample.Client.Services;

namespace FilterTableComponentSample.Client.Shared
{
    public class ToastBase : ComponentBase, IDisposable
    {
        [Inject] ToastService ToastService { get; set; }

        protected string Heading { get; set; }
        protected string Message { get; set; }
        protected bool IsVisible { get; set; }
        protected string BackgroundCssClass { get; set; }
        protected string IconCssClass { get; set; }
        protected string XPos { get; set; }
        protected string YPos { get; set; }

        protected int opacity = 1;
        protected override void OnInitialized()
        {
            ToastService.OnShow += ShowToast;
            ToastService.OnHide += HideToast;
        }

        private void ShowToast(string message, ToastLevel level,string _xpos = "right", string _ypos = "bottom")
        {
            opacity = 1;
            BuildToastSettings(level, message, _xpos, _ypos);
            IsVisible = true;
            StateHasChanged();
        }

        private void HideToast()
        {
            IsVisible = false;
            StateHasChanged();
        }

        private void BuildToastSettings(ToastLevel level, string message, string _xpos = "right", string _ypos="bottom")
        {
            XPos = _xpos;YPos = _ypos;
            if (_xpos != "right") XPos = "left";
            if (_ypos != "bottom") YPos = "top";

            switch (level)
            {
                case ToastLevel.Info:
                    BackgroundCssClass = "bg-info";
                    IconCssClass = "info";
                    Heading = "Info";
                    break;
                case ToastLevel.Success:
                    BackgroundCssClass = "bg-success";
                    IconCssClass = "check";
                    Heading = "Success";
                    break;
                case ToastLevel.Warning:
                    BackgroundCssClass = "bg-warning";
                    IconCssClass = "exclamation";
                    Heading = "Warning";
                    break;
                case ToastLevel.Error:
                    BackgroundCssClass = "bg-danger";
                    IconCssClass = "times";
                    Heading = "Error";
                    break;
            }

            Message = message;
        }

        public void Dispose()
        {
            ToastService.OnShow -= ShowToast;
        }
    }
}
