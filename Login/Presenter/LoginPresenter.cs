using PointOfSalesApp.Model;
using PointOfSalesApp.View;
using System;
using System.Globalization;

namespace PointOfSalesApp.Presenter
{
    class MyPresenter
    {
        private readonly IView mView;
        private IModel mModel;


        public MyPresenter(IView mView)
        {
            this.mView = mView;
            mModel = new LoginModel();
        }

        public void doLogin() {
            mView.onLoginResult(mModel.validateLogin());
        }

        public void validateInput(string username, string password) {
            mModel.username = username;
            mModel.userPassword = password;
            mView.onValidateInput(mModel.validateInputs());
        }
    }
}
