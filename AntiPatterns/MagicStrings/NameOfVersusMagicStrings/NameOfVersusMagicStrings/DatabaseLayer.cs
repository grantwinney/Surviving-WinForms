using System;

namespace NameOfVersusMagicStrings
{
    public class DatabaseLayer
    {
        [Obsolete("Use the " + nameof(SaveOrUpdate) + " method")]
        public void SaveUsername(string userId, string username)
        {
            throw new NotImplementedException($"Told you {nameof(SaveUsername)} was obsolete... use {nameof(SaveOrUpdate)}!");
        }

        public void SaveOrUpdate(string userId, string username)
        {
            // Beep boop, values being saved to the database...
        }
    }
}
