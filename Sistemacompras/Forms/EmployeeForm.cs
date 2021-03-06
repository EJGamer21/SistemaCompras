﻿using Sistemacompras.Dto;
using Sistemacompras.Entities;
using Sistemacompras.Enum;
using Sistemacompras.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistemacompras.Forms
{
    public partial class EmployeeForm : Form
    {
        public string mode;
        public DataGridViewRow row;
        private readonly EmployeeRepository employeeRepo;
        private readonly PurchaseContext _Context;
        private readonly EmployeeDto employee;

        public EmployeeForm(string mode, DataGridViewRow row)
        {
            InitializeComponent();
            _Context = new PurchaseContext();
            employeeRepo = new EmployeeRepository();
            employee = new EmployeeDto();

            if (mode != null)
            {
                this.mode = mode;

                if (this.mode.Equals("Create"))
                {
                    Text = "Crear Empleado";
                }

                if (this.mode.Equals("Edit"))
                {
                    Text = "Editar Empleado";
                    this.row = row;
                }
            }
        }

        private void EmployeeForm_load(object sender, EventArgs e)
        {
            var users = _Context.Users
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();
            var departments = _Context.Departments
                .Where(x => x.StatusId == (int)StatusEnum.Active)
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();
            var statuses = _Context.Statuses
                .Where(x => x.Id == (int)StatusEnum.Active
                    || x.Id == (int)StatusEnum.Inactive
                )
                .Select(x => new
                {
                    x.Name
                })
                .ToArray();

            foreach (var user in users)
            {
                UserCbx.Items.Add(user.Name);
            }

            foreach (var department in departments)
            {
                DepartmentCbx.Items.Add(department.Name);
            }

            foreach (var status in statuses)
            {
                StatusCbx.Items.Add(status.Name);
            }

            if (mode.Equals("Create") == false)
            {
                try
                {
                    employee.Id = int.Parse(row.Cells[0].Value.ToString());
                    employee.Name = row.Cells[2].Value.ToString();
                    employee.Department = row.Cells[3].Value.ToString();
                    employee.Status = row.Cells[4].Value.ToString();

                    IdTxt.Text = employee.Id.ToString();
                    UserCbx.Text = employee.Name;
                    DepartmentCbx.Text = employee.Department;
                    StatusCbx.Text = employee.Status;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(
                        text: "Error cargando los datos",
                        caption: "Error",
                        buttons: MessageBoxButtons.OK,
                        icon: MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = "0";
                if (!IdTxt.Text.Equals(""))
                    id = IdTxt.Text.ToString();

                employee.Id = int.Parse(id);
                employee.Name = UserCbx.SelectedIndex.ToString();
                employee.Department = DepartmentCbx.SelectedIndex.ToString();
                employee.Status = StatusCbx.SelectedIndex.ToString();

                Employee item = new Employee
                {
                    Id = employee.Id,
                    UserId = _Context.Users
                        .Where(x => x.Id == (UserCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    DepartmentId = _Context.Departments
                        .Where(x => x.Id == (DepartmentCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault(),
                    StatusId = _Context.Statuses
                        .Where(x => x.Id == (StatusCbx.SelectedIndex + 1))
                        .Select(x => x.Id)
                        .FirstOrDefault()
                };

                if (mode.Equals("Create"))
                {
                    employeeRepo.Create(item);
                }
                else
                {
                    employeeRepo.Update(item);
                }

                Close();

                MessageBox.Show(
                    text: "Registro guardado con exito",
                    caption: "Informacion",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(
                    text: "Error al guardar los datos",
                    caption: "Error",
                    buttons: MessageBoxButtons.OK,
                    icon: MessageBoxIcon.Error);
            }
        }
    }
}
