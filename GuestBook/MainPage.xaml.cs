using System.ComponentModel;
using System.Windows;
using GuestBook.Models;

namespace GuestBook
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();

            Model.DoSendData += OnSendProductsCommandExecuteCommand;
            ServiceProvider.Instance.AddRecordCompleted += OnAddRecordCompleted;
            ServiceProvider.Instance.GetRecordsInfoCompleted += (sender, e) =>
                {
                    if (e.Error == null)
                    {
                        if (e.Result > 0)
                        {
                            ServiceProvider.Instance.GetAllRecordsAsync();
                        }
                        else
                        {
                            IsProcess = false;
                        }
                    }
                };
            ServiceProvider.Instance.GetAllRecordsCompleted += (sender, e) =>
                {
                    if (e.Error == null)
                    {
                        Model.Records = e.Result;
                        IsProcess = false;
                    }
                };

            ServiceProvider.Instance.GetRecordsInfoAsync();
        }
        
        #region Public Properties

        public static readonly DependencyProperty ModelProperty =
            DependencyProperty.Register("ModelProperty", typeof(GuestModel), typeof(MainPage), new PropertyMetadata(new GuestModel()));

        public GuestModel Model
        {
            get { return (GuestModel)GetValue(ModelProperty); }
            set { SetValue(ModelProperty, value); }
        }

        public static readonly DependencyProperty IsProcessProperty =
            DependencyProperty.Register("IsProcess", typeof(bool), typeof(MainPage), new PropertyMetadata(true));

        public bool IsProcess
        {
            get { return (bool)GetValue(IsProcessProperty); }
            set { SetValue(IsProcessProperty, value); }
        }               

        #endregion

        #region Event Handlers

        private void OnAddRecordCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                ServiceProvider.Instance.GetAllRecordsAsync();
                Model.ClearData();
            }
        }

        private void OnSendProductsCommandExecuteCommand(object sender, System.EventArgs e)
        {
            IsProcess = true;
            ServiceProvider.Instance.AddRecordAsync("Key", Model.ToGuestRecord());
        }       

        #endregion
    }
}
