class GraduateStudent : Student
{
    private string thesisTopic;
    private string advisor;
    
    // Constructor calls base Student constructor
    public GraduateStudent(string firstName, string lastName, string email, 
                           string[] hobbies, int[] grades, string thesisTopic, 
                           string advisor)
        : base(firstName, lastName, email, hobbies, grades)
    {
        this.thesisTopic = thesisTopic;
        this.advisor = advisor;
    }
    
    public void DisplayGraduateStudentInfo()
    {
        DisplayStudentInfo(); // Inherited from Student
        Console.WriteLine($"Thesis Topic: {thesisTopic}");
        Console.WriteLine($"Advisor: {advisor}");
    }
}
