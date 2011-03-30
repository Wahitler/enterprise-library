﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ContainerModel;
using Microsoft.Practices.EnterpriseLibrary.Logging.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Logging.Properties;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Configuration
{
    /// <summary>
    /// Configuration for the IsolatedStorageTraceListener.
    /// </summary>
    public class IsolatedStorageTraceListenerData : TraceListenerData
    {
        private const int defaultMaxSizeInBytes = 1024 * 256;

        /// <summary>
        /// Initializes a new instance of the <see cref="IsolatedStorageTraceListener"/> class.
        /// </summary>
        public IsolatedStorageTraceListenerData()
        {
            this.MaxSizeInBytes = defaultMaxSizeInBytes;
        }

        /// <summary>
        /// Gets or sets the maximum size in bytes to be used when storing entries.
        /// </summary>
        public int MaxSizeInBytes { get; set; }

        /// <summary>
        /// Gets or sets the name of the repository for entries.
        /// </summary>
        public string RepositoryName { get; set; }

        /// <summary>
        /// Gets the creation expression used to produce a <see cref="TypeRegistration"/> during
        /// <see cref="GetRegistrations"/>.
        /// </summary>
        /// <returns>A <see cref="Expression"/> that creates an <see cref="IsolatedStorageTraceListener"/></returns>
        protected override Expression<Func<TraceListener>> GetCreationExpression()
        {
            return () => new IsolatedStorageTraceListener(Container.Resolved<ILogEntryRepository>(this.RepositoryName));
        }

        /// <summary>
        /// Returns the type <see cref="TypeRegistration"/> entries for this configuration object.
        /// </summary>
        /// <returns>A set of registry entries.</returns>        
        /// <remarks>Two registrations are returned for this object, one for the trace listener itself and one for its 
        /// isolated storage repository.</remarks>
        public override IEnumerable<TypeRegistration> GetRegistrations()
        {
            if (this.RepositoryName == null)
            {
                throw new InvalidOperationException(
                    string.Format(CultureInfo.CurrentCulture, Resources.ErrorRepositoryNameNotSet, this.Name));
            }

            var repositoryTypeRegistration =
                new TypeRegistration<ILogEntryRepository>(
                    () => new IsolatedStorageLogEntryRepository(this.RepositoryName, this.MaxSizeInBytes))
                    {
                        IsPublicName = true,
                        Lifetime = TypeRegistrationLifetime.Singleton,
                        Name = this.RepositoryName,
                    };

            var registrations = base.GetRegistrations().ToList();
            registrations.Add(repositoryTypeRegistration);

            return registrations;
        }
    }
}