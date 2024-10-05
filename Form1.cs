using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Connecting_VM
{
    public partial class Form1 : Form
    {
        private List<ADUsers> people = new List<ADUsers>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryEntry entry = new DirectoryEntry("LDAP://192.168.56.101", "Administrator","hisoka5?");           
                DirectorySearcher searcher = new DirectorySearcher(entry);
                searcher.Filter = "(objectClass=user)";

                SearchResultCollection results = searcher.FindAll();
                //dataGridView1.Columns.Add("DisplayName", "Display Name");
                //dataGridView1.Columns.Add("UserName", "User Name");

                // Iterate over each result (user)
                foreach (SearchResult result in results)
                {
                    //Console.WriteLine($"Properties for user '{result.Properties["sAMAccountName"][0]}':");
                   
                    // Iterate over all properties in the result
                    /*foreach (string propertyName in result.Properties.PropertyNames)
                    {
                        Console.WriteLine($"Property: {propertyName}");
                        // Print all values associated with this property
                        foreach (object propertyValue in result.Properties[propertyName])
                        {
                            Console.WriteLine($"  Value: {propertyValue}");
                        }

                    }*/
                    //string name = result.Properties["givenname"][0].ToString();
                    string DisplayName = result.Properties["cn"][0].ToString();
                    string UserName = result.Properties["samaccountname"][0].ToString();
                    //string name = result.Properties["givenname"][0].ToString();

                   // Console.WriteLine(); // Add a blank line between users

                    //dataGridView1.Rows.Add(DisplayName, UserName);
                    people.Add(new ADUsers
                    {
                        DisplayName = DisplayName,
                        UserName= UserName
                    });
                    
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = people;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                string email = string.Empty;
                string firstName = string.Empty;
                string lastName = string.Empty;
                string displayName = string.Empty;
                string phoneNumber = string.Empty;

                string ldapPath = "LDAP://192.168.56.101";
                string adminusername = "Administrator";
                string adminpassword = "hisoka5?";

                try
                {
                    using (DirectoryEntry rootEntry = new DirectoryEntry(ldapPath, adminusername, adminpassword))
                    {
                        using (DirectorySearcher searcher = new DirectorySearcher(rootEntry))
                        {
                            // Search for the user by sAMAccountName (username)
                            searcher.Filter = $"(&(objectClass=user)(sAMAccountName={selectedUsername}))";

                            // Specify the properties to load from AD
                            searcher.PropertiesToLoad.Add("mail");
                            searcher.PropertiesToLoad.Add("givenName"); // First Name
                            searcher.PropertiesToLoad.Add("sn"); // Last Name (surname)
                            searcher.PropertiesToLoad.Add("displayName"); // Display Name
                            searcher.PropertiesToLoad.Add("telephoneNumber"); // Telephone Number

                            searcher.SearchScope = SearchScope.Subtree;

                            // Find the user
                            SearchResult result = searcher.FindOne();

                            if (result != null)
                            {
                                if (result.Properties.Contains("mail"))
                                {
                                    email = result.Properties["mail"][0]?.ToString();
                                }
                                if (result.Properties.Contains("givenName"))
                                {
                                    firstName = result.Properties["givenName"][0]?.ToString();
                                }
                                if (result.Properties.Contains("sn"))
                                {
                                    lastName = result.Properties["sn"][0]?.ToString();
                                }
                                if (result.Properties.Contains("displayName"))
                                {
                                    displayName = result.Properties["displayName"][0]?.ToString();
                                }
                                if (result.Properties.Contains("telephoneNumber"))
                                {
                                    phoneNumber = result.Properties["telephoneNumber"][0]?.ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found or does not have the required attributes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while fetching user information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Populate the text boxes with the retrieved values
                textBoxMail.Text = email;
                textBoxFN_Update.Text = firstName;
                textBoxLN_Update.Text = lastName;
                textBoxDN_Update.Text = displayName;
                textBoxPhone.Text = phoneNumber;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string userName = selectedRow.Cells["UserName"].Value.ToString();
            string ldapPath = "LDAP://192.168.56.101" ; 
            string adminusername = "Administrator"; // Provide an account with sufficient permissions
            string adminpassword = "hisoka5?";
            //Console.WriteLine("Selected Username: " + userName);

            try
            {
                using (DirectoryEntry rootEntry = new DirectoryEntry(ldapPath, adminusername, adminpassword))
                {
                    using (DirectorySearcher searcher = new DirectorySearcher(rootEntry))
                    {
                        searcher.Filter = "(sAMAccountName=" + userName + ")";
                        SearchResult result = searcher.FindOne();

                        if (result != null)
                        {
                            DirectoryEntry entry = result.GetDirectoryEntry();
                            entry.DeleteTree();
                            entry.CommitChanges();
                            var userToRemove = people.FirstOrDefault(user => user.UserName == userName);
                            people.Remove(userToRemove);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = people;
                            //dataGridView1.Rows.Remove(selectedRow);
                            MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not found in Active Directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_User_Click(object sender, EventArgs e)
        {
            
            string password = textBoxPassword.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string username = firstName + lastName[0];

            string ldapPath = "LDAP://192.168.56.101";
            string adminusername = "Administrator"; // Provide an account with sufficient permissions
            string adminpassword = "hisoka5?";

            try
            {
                using (DirectoryEntry rootEntry = new DirectoryEntry(ldapPath, adminusername, adminpassword))
                {
                    using (DirectoryEntry newUser = rootEntry.Children.Add("CN=" + username, "user"))
                    {
                        newUser.Properties["sAMAccountName"].Value = username;
                        newUser.Properties["givenName"].Value = firstName;
                        newUser.Properties["sn"].Value = lastName;

                        people.Add(new ADUsers
                        {
                            DisplayName = firstName + lastName,
                            UserName = username
                        });

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = people;

                        newUser.CommitChanges();

                        int userAccountControlFlags = (int)newUser.Properties["userAccountControl"].Value;
                        userAccountControlFlags &= ~0x2; // Clear the ACCOUNTDISABLE flag (0x2)
                        userAccountControlFlags &= ~0x40; // Clear the PASSWD_CANT_CHANGE flag (0x40)

                        newUser.Properties["userAccountControl"].Value = userAccountControlFlags;

                        newUser.CommitChanges();

                        try
                        {
                            newUser.Invoke("SetPassword", new object[] { password });
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred while setting the password: " + ex.InnerException?.Message ?? ex.Message,
                                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                }

                MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string groupName = textBoxAddNewADGroup.Text;
            string ldapPath = "LDAP://192.168.56.101"; // Adjust this if needed to point to a specific OU
            string adminusername = "Administrator"; // Provide an account with sufficient permissions
            string adminpassword = "hisoka5?";

            try
            {
                using (DirectoryEntry rootEntry = new DirectoryEntry(ldapPath, adminusername, adminpassword))
                {
                    using (DirectoryEntry newGroup = rootEntry.Children.Add("CN=" + groupName, "group"))
                    {
                        newGroup.CommitChanges();
                        textBoxAddNewADGroup.Clear();
                    }
                }


                MessageBox.Show("Group added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + (ex.InnerException?.Message ?? ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected username from the DataGridView
                string selectedUsername = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();

                // Get the values from the text boxes
                string newEmail = textBoxMail.Text;
                string newFirstName = textBoxFN_Update.Text;
                string newLastName = textBoxLN_Update.Text;
                string newDisplayName = textBoxDN_Update.Text;
                string newPhoneNumber = textBoxPhone.Text;

                string ldapPath = "LDAP://192.168.56.101";
                string adminusername = "Administrator";
                string adminpassword = "hisoka5?";

                try
                {
                    using (DirectoryEntry rootEntry = new DirectoryEntry(ldapPath, adminusername, adminpassword))
                    {
                        using (DirectorySearcher searcher = new DirectorySearcher(rootEntry))
                        {
                            // Search for the user by sAMAccountName (username)
                            searcher.Filter = $"(&(objectClass=user)(sAMAccountName={selectedUsername}))";
                            searcher.SearchScope = SearchScope.Subtree;

                            SearchResult result = searcher.FindOne();

                            if (result != null)
                            {
                                DirectoryEntry userEntry = result.GetDirectoryEntry();

                                // Update the user's properties
                                if (!string.IsNullOrEmpty(newEmail))
                                    userEntry.Properties["mail"].Value = newEmail;

                                if (!string.IsNullOrEmpty(newFirstName))
                                    userEntry.Properties["givenName"].Value = newFirstName;

                                if (!string.IsNullOrEmpty(newLastName))
                                    userEntry.Properties["sn"].Value = newLastName;

                                if (!string.IsNullOrEmpty(newDisplayName))
                                    userEntry.Properties["displayName"].Value = newDisplayName;

                                if (!string.IsNullOrEmpty(newPhoneNumber))
                                    userEntry.Properties["telephoneNumber"].Value = newPhoneNumber;

                                // Commit the changes to the directory
                                userEntry.CommitChanges();

                                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("User not found in Active Directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user from the list.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
