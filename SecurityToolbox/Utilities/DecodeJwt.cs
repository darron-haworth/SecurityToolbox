using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SecurityToolbox.Utilities
{
    public class DecodeJwt
    {
        public string DecodeJwtToken(string input)
        {
            //Assume the input is in a control called txtJwtIn,
            //and the output will be placed in a control called txtJwtOut
            var txtJwtOut = "";
            var jwtHandler = new JwtSecurityTokenHandler();
            var jwtInput = input;

            //Check if readable token (string is in a JWT format)
            var readableToken = jwtHandler.CanReadToken(jwtInput);

            if (readableToken != true)
            {
                txtJwtOut = "The token doesn't seem to be in a proper JWT format.";
                return txtJwtOut;
            }
            if (readableToken == true)
            {
                var token = jwtHandler.ReadJwtToken(jwtInput);

                //Extract the headers of the JWT
                var headers = token.Header;
                var jwtHeader = "{";
                foreach (var h in headers)
                {
                    jwtHeader += '"' + h.Key + "\":\"" + h.Value + "\",";
                }
                jwtHeader += "}";
                txtJwtOut = "Header:\r\n" + JToken.Parse(jwtHeader).ToString(Formatting.Indented);

                //Extract the payload of the JWT
                var claims = token.Claims;
                var jwtPayload = "{";
                foreach (Claim c in claims)
                {
                    jwtPayload += '"' + c.Type + "\":\"" + c.Value + "\",";
                }
                jwtPayload += "}";
                txtJwtOut += "\r\nPayload:\r\n" + JToken.Parse(jwtPayload).ToString(Formatting.Indented);
                return txtJwtOut;
            }
            return "not";
        }
    }
}
