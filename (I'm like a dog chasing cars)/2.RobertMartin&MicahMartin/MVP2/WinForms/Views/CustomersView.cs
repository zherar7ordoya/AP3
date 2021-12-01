using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MvpSample.Common.Interfaces;
using MvpSample.Common.ViewModels;
using MvpSample.WinForms.Models;
using MvpSample.WinForms.Presenters;

namespace MvpSample.WinForms.Views
{
    public partial class CustomersView : Form, ICustomersView
    {
        public CustomersView() { InitializeComponent(); }
        private CustomersPresenter m_presenter;
        public CustomersView(CustomerDao dao) : this()
        { m_presenter = new CustomersPresenter(this, dao); }
        public void ShowCustomers(IEnumerable<CustomerViewModel> customerList)
        { cusomerViewModelBindingSource.DataSource = customerList; }
        private void m_btnAddCustomer_Click(object sender, EventArgs e)
        { m_presenter.AddCustomerClicked(); }
    }
}