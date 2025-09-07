using NP.Lti13Platform.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NP.Lti13Platform.Core.Models;

/// <summary>
/// Represents a physical address following the OpenID Connect Core specification.
/// </summary>
public class UserAddress : IUserAddress
{
    /// <summary>
    /// Full mailing address, formatted for display or use on a mailing label. This field MAY contain multiple lines, separated by newlines. Newlines can be represented either as a carriage return/line feed pair ("\r\n") or as a single line feed character ("\n").
    /// </summary>
    public string? Formatted { get; set; }

    /// <summary>
    /// Full street address component, which MAY include house number, street name, Post Office Box, and multi-line extended street address information. This field MAY contain multiple lines, separated by newlines. Newlines can be represented either as a carriage return/line feed pair ("\r\n") or as a single line feed character ("\n").
    /// </summary>
    public string? StreetAddress { get; set; }

    /// <summary>
    /// City or locality component.
    /// </summary>
    public string? Locality { get; set; }

    /// <summary>
    /// State, province, prefecture, or region component.
    /// </summary>
    public string? Region { get; set; }

    /// <summary>
    /// Zip code or postal code component.
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Country name component.
    /// </summary>
    public string? Country { get; set; }
}