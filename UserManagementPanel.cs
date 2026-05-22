using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class UserManagementPanel : UserControl
    {
        private UserService userService;
        private DataGridView usersGridView;
        private TextBox fullNameTextBox;
        private TextBox emailTextBox;
        private TextBox contactTextBox;
        private TextBox roleTextBox;
        private TextBox passwordTextBox;
        private Button addUserButton;
        private Button updateUserButton;
        private Button deleteUserButton;
        private Button refreshButton;
        private Label statusLabel;

        public UserManagementPanel()
        {
            userService = new UserService();
            InitializeComponent();
            LoadUsers();
        }

        private void InitializeComponent()
        {
            usersGridView = new DataGridView();
            fullNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            contactTextBox = new TextBox();
            roleTextBox = new TextBox();
            passwordTextBox = new TextBox();
            addUserButton = new Button();
            updateUserButton = new Button();
            deleteUserButton = new Button();
            refreshButton = new Button();
            statusLabel = new Label();

            SuspendLayout();

            usersGridView.AllowUserToAddRows = false;
            usersGridView.AllowUserToDeleteRows = false;
            usersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersGridView.BackgroundColor = Color.White;
            usersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersGridView.Location = new Point(12, 12);
            usersGridView.MultiSelect = false;
            usersGridView.Name = "usersGridView";
            usersGridView.ReadOnly = true;
            usersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersGridView.Size = new Size(620, 300);
            usersGridView.TabIndex = 0;
            usersGridView.SelectionChanged += UsersGridView_SelectionChanged;

            Label titleLabel = new Label();
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.Location = new Point(12, 320);
            titleLabel.Text = "User Management";

            Label fullNameLabel = new Label();
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(12, 360);
            fullNameLabel.Text = "Full Name:";

            fullNameTextBox.Location = new Point(100, 356);
            fullNameTextBox.Size = new Size(200, 23);

            Label emailLabel = new Label();
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 390);
            emailLabel.Text = "Email:";

            emailTextBox.Location = new Point(100, 386);
            emailTextBox.Size = new Size(200, 23);

            Label contactLabel = new Label();
            contactLabel.AutoSize = true;
            contactLabel.Location = new Point(330, 360);
            contactLabel.Text = "Contact:";

            contactTextBox.Location = new Point(405, 356);
            contactTextBox.Size = new Size(200, 23);

            Label roleLabel = new Label();
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(330, 390);
            roleLabel.Text = "Role:";

            roleTextBox.Location = new Point(405, 386);
            roleTextBox.Size = new Size(200, 23);

            Label passwordLabel = new Label();
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 420);
            passwordLabel.Text = "Password:";

            passwordTextBox.Location = new Point(100, 416);
            passwordTextBox.Size = new Size(200, 23);
            passwordTextBox.UseSystemPasswordChar = true;

            addUserButton.Location = new Point(12, 455);
            addUserButton.Size = new Size(140, 35);
            addUserButton.Text = "Add User";
            addUserButton.Click += AddUserButton_Click;

            updateUserButton.Location = new Point(165, 455);
            updateUserButton.Size = new Size(140, 35);
            updateUserButton.Text = "Update User";
            updateUserButton.Click += UpdateUserButton_Click;

            deleteUserButton.Location = new Point(318, 455);
            deleteUserButton.Size = new Size(140, 35);
            deleteUserButton.Text = "Delete User";
            deleteUserButton.Click += DeleteUserButton_Click;

            refreshButton.Location = new Point(471, 455);
            refreshButton.Size = new Size(140, 35);
            refreshButton.Text = "Refresh";
            refreshButton.Click += RefreshButton_Click;

            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(12, 505);
            statusLabel.Size = new Size(600, 20);
            statusLabel.ForeColor = Color.DimGray;

            Controls.Add(usersGridView);
            Controls.Add(titleLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(fullNameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(contactLabel);
            Controls.Add(contactTextBox);
            Controls.Add(roleLabel);
            Controls.Add(roleTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(addUserButton);
            Controls.Add(updateUserButton);
            Controls.Add(deleteUserButton);
            Controls.Add(refreshButton);
            Controls.Add(statusLabel);

            Name = "UserManagementPanel";
            Size = new Size(640, 540);
            BackColor = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadUsers()
        {
            try
            {
                List<User> users = userService.GetAllUsers();
                usersGridView.DataSource = users;
                statusLabel.Text = $"Loaded {users.Count} user(s). Select a row to edit or delete.";
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Error loading users: " + ex.Message;
            }
        }

        private void ClearForm()
        {
            fullNameTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            roleTextBox.Clear();
            passwordTextBox.Clear();
        }

        private int? GetSelectedUserId()
        {
            if (usersGridView.SelectedRows.Count == 0) return null;
            if (usersGridView.SelectedRows[0].DataBoundItem is User user)
            {
                return user.UserId;
            }
            return null;
        }

        private void UsersGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (GetSelectedUserId() is int selectedUserId)
            {
                if (usersGridView.SelectedRows[0].DataBoundItem is User user)
                {
                    fullNameTextBox.Text = user.FullName;
                    emailTextBox.Text = user.Email;
                    contactTextBox.Text = user.ContactNumber;
                    roleTextBox.Text = user.Role;
                    passwordTextBox.Clear();
                    statusLabel.Text = "Editing user " + user.FullName + ". Leave password blank to keep existing password.";
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(fullNameTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    MessageBox.Show("Full name and email are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User user = new User
                {
                    FullName = fullNameTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    ContactNumber = contactTextBox.Text.Trim(),
                    Role = roleTextBox.Text.Trim()
                };

                if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    MessageBox.Show("Password is required for a new user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int insertedId = userService.AddUser(user, passwordTextBox.Text);
                ClearForm();
                LoadUsers();
                MessageBox.Show($"User created successfully (ID: {insertedId}).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? selectedUserId = GetSelectedUserId();
                if (!selectedUserId.HasValue)
                {
                    MessageBox.Show("Select a user from the list first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                User user = new User
                {
                    UserId = selectedUserId.Value,
                    FullName = fullNameTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    ContactNumber = contactTextBox.Text.Trim(),
                    Role = roleTextBox.Text.Trim()
                };

                bool updated = userService.UpdateUser(user, string.IsNullOrWhiteSpace(passwordTextBox.Text) ? null : passwordTextBox.Text);
                if (updated)
                {
                    ClearForm();
                    LoadUsers();
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No user was updated. Please confirm the selected row.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? selectedUserId = GetSelectedUserId();
                if (!selectedUserId.HasValue)
                {
                    MessageBox.Show("Select a user from the list first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes) return;

                bool deleted = userService.DeleteUser(selectedUserId.Value);
                if (deleted)
                {
                    ClearForm();
                    LoadUsers();
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("User could not be deleted.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadUsers();
            ClearForm();
        }
    }
}
