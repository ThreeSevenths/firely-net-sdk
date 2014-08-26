﻿/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.github.com/furore-fhir/spark/master/LICENSE
 */


using System;
using System.Collections.Generic;
using System.IO;
using Hl7.Fhir.Model;
using Hl7.Fhir.Support;

namespace Hl7.Fhir.Introspection.Source
{
    /// <summary>
    /// Reads FHIR artifacts (Profiles, ValueSets, ...) using a list of other IArtifactSources
    /// </summary>
    public class ArtifactResolver : IArtifactSource
    {
        private readonly List<IArtifactSource> _sources = new List<IArtifactSource>();

        public ArtifactResolver() : this(new FileArtifactSource(), new CoreZipArtifactSource(), new WebArtifactSource())
        {            
        }

        public ArtifactResolver(IEnumerable<IArtifactSource> sources)
        {
            if (sources == null) throw Error.ArgumentNull("sources");

            _sources.AddRange(sources);
        }

        public ArtifactResolver(params IArtifactSource[] sources)
        {
            if (sources == null) throw Error.ArgumentNull("sources");

            _sources.AddRange(sources);
        }

        public void AddSource(IArtifactSource source)
        {
            _sources.Add(source);
        }

        public void RemoveSource(IArtifactSource source)
        {
            _sources.Remove(source);
        }

        public IList<IArtifactSource> Sources
        { 
            get { return _sources; } 
        }

        private bool _prepared = false;

        public void Prepare()
        {
            if (!_prepared)
            {
                foreach (var source in Sources) source.Prepare();
                _prepared = true;
            }
        }

        public Stream ReadContentArtifact(string name)
        {
            if (!_prepared) Prepare();

            foreach (var source in Sources)
            {
                try
                {
                    var result = source.ReadContentArtifact(name);

                    if (result != null) return result;
                }
                catch
                {
                    // Don't do anything, just try the next IArtifactSource
                }
            }

            // None of the IArtifactSources succeeded in returning a result
            return null;
        }

        public Resource ReadResourceArtifact(Uri artifactId)
        {
            if (!_prepared) Prepare();

            foreach (var source in Sources)
            {
                try
                {
                    var result = source.ReadResourceArtifact(artifactId);

                    if (result != null) return result;
                }
                catch
                {
                    // Don't do anything, just try the next IArtifactSource
                }
            }

            // None of the IArtifactSources succeeded in returning a result
            return null;
        }
    }
}
