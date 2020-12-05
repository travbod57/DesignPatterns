namespace Mediator.InstantMessenger
{
    /// <summary>
    /// Mediator class
    /// </summary>
    public class Messenger
    {
        private Alex _alex;
        private Jamie _jamie;

        public Alex Alex
        {
            set { _alex = value; }
        }

        public Jamie Jamie
        {
            set { _jamie = value; }
        }

        public void Send(string message, StaffMember staffMember)
        {
            if (staffMember is Alex)
            {
                _jamie.Notify(message);
            }
            else
            {
                _alex.Notify(message);
            }
        }
    }
}