using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBase.Base
{
    public class ValidationResult
    {
        public List<string> Errors { get; private set; }

        public bool IsValid
        {
            get { return Errors.Count == 0; }
        }

        public ValidationResult()
        {
            Errors = new List<string>();
        }

        public void AddError(string error)
        {
            Errors.Add(error);
        }

        public void AddErrors(IEnumerable<string> errors)
        {
            Errors.AddRange(errors);
        }
    }
}
