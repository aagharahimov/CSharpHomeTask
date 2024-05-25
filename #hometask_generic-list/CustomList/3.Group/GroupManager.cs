using System;
using System.Collections.Generic;

public class GroupManager
{
    private List<Group> groups;

    public GroupManager()
    {
        groups = new List<Group>();
    }

    public bool AddGroup(Group group)
    {
        if (!ContainsGroup(group.Name))
        {
            groups.Add(group);
            return true;
        }
        return false;
    }
    public bool ContainsGroup(string name)
    {
        foreach (var group in groups)
        {
            if (group.Name == name)
            {
                return true;
            }
        }
        return false;
    }


    // Get all groups
    public void GetAllGroups()
    {
        foreach (var group in groups)
        {
            Console.WriteLine(group.Name);
        }
    }
}
