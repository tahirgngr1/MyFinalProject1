using Core.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccesToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
