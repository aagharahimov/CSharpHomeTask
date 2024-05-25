public static class Program
{
    public static void Main(string[] args)
    {
        GroupManager groupManager = new GroupManager();

        groupManager.AddGroup(new Group("group 1"));
        groupManager.AddGroup(new Group("group 2"));
        groupManager.AddGroup(new Group("group 2")); 
        groupManager.AddGroup(new Group("group 4"));

        
        groupManager.GetAllGroups();
    }
}