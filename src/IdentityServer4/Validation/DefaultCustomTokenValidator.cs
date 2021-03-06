// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Services;
using IdentityServer4.Stores;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace IdentityServer4.Validation
{
    /// <summary>
    /// Default custom token validator
    /// </summary>
    [Obsolete("Deriving from/using this type is not recommended. It will change in the next version")]
    public class DefaultCustomTokenValidator : ICustomTokenValidator
    {
        /// <summary>
        /// The logger
        /// </summary>
        protected readonly ILogger Logger;

        /// <summary>
        /// The user service
        /// </summary>
        protected readonly IProfileService Profile;

        /// <summary>
        /// The client store
        /// </summary>
        protected readonly IClientStore Clients;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultCustomTokenValidator"/> class.
        /// </summary>
        /// <param name="profile">The profile service</param>
        /// <param name="clients">The client store.</param>
        /// <param name="logger">The logger</param>
        public DefaultCustomTokenValidator(IProfileService profile, IClientStore clients, ILogger<DefaultCustomTokenValidator> logger)
        {
            Logger = logger;
            Profile = profile;
            Clients = clients;
        }

        /// <summary>
        /// Custom validation logic for access tokens.
        /// </summary>
        /// <param name="result">The validation result so far.</param>
        /// <returns>
        /// The validation result
        /// </returns>
        public virtual Task<TokenValidationResult> ValidateAccessTokenAsync(TokenValidationResult result)
        {
            return Task.FromResult(result);
        }

        /// <summary>
        /// Custom validation logic for identity tokens.
        /// </summary>
        /// <param name="result">The validation result so far.</param>
        /// <returns>
        /// The validation result
        /// </returns>
        public virtual Task<TokenValidationResult> ValidateIdentityTokenAsync(TokenValidationResult result)
        {
            return Task.FromResult(result);
        }
    }
}