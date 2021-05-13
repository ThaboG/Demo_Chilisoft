using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Enums
{
    [EnumCustomMember(Text = "Types of users")]
    public enum UserTypes
    {
        [DatabaseID(ID = "9D708A99-205C-4ABA-BC99-C87F0ED26846")]
        Admin,
        [DatabaseID(ID = "76AE7E2C-A80B-4F5E-B790-D9CE1E5096F6")]
        Client,
        [DatabaseID(ID = "A9D77C85-E2DA-40D5-8A10-DC41E06E5EDD")]
        Employee
    }
}
