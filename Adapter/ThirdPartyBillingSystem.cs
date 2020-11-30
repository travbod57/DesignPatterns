namespace Adapter
{
    /// <summary>
    /// This is the ADAPTEE
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employees information as a List to process each employee salary
        public string[,] GetEmployees()
        {
            // maybe this is a database call or from API
            return new string[5, 4]
                        {
                            {"101","John","SE","10000"},
                            {"102","Smith","SE","20000"},
                            {"103","Dev","SSE","30000"},
                            {"104","Pam","SE","40000"},
                            {"105","Sara","SSE","50000"}
                        };
        }
    }
}