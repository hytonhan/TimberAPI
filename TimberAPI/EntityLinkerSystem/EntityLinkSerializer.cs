﻿using Timberborn.Persistence;

namespace TimberbornAPI.EntityLinkerSystem
{
    /// <summary>
    /// Defines how and instance of EntityLink should be serialized.
    /// Used when an EntityLinker which contains EntityLinks is saved/loaded
    /// </summary>
    public class EntityLinkSerializer : IObjectSerializer<EntityLink>
    {
        protected static readonly PropertyKey<EntityLinker> LinkerKey = new PropertyKey<EntityLinker>("Linker");
        protected static readonly PropertyKey<EntityLinker> LinkeeKey = new PropertyKey<EntityLinker>("Linkee");

        public virtual Obsoletable<EntityLink> Deserialize(IObjectLoader objectLoader)
        {
            var linker = objectLoader.Get(LinkerKey);
            var linkee = objectLoader.Get(LinkeeKey);
            var link = new EntityLink(linker, linkee);
            return link;
        }

        public virtual void Serialize(EntityLink value, IObjectSaver objectSaver)
        {
            objectSaver.Set(LinkerKey, value.Linker);
            objectSaver.Set(LinkeeKey, value.Linkee);
        }
    }
}
