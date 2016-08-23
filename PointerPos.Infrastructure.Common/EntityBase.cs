﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PointerPOS.Infrastructure.Common
{
    /// <summary>
    /// Base class for all of entities in a domain model
    /// </summary>
    /// <typeparam name="IdType">Type of the id/key of the entity</typeparam>
    public abstract class EntityBase<IdType>
    {
        public IdType Id { get; set; }

        /// <summary>
        /// Equality comparison of an entity with another one
        /// </summary>
        /// <param name="entity">Entity to compare with</param>
        /// <returns>True, if two entities are same</returns>
        public override bool Equals(object entity)
        {
            return entity != null && entity is EntityBase<IdType> && this == (EntityBase<IdType>)entity;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        public static bool operator ==(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
                return true;
            if ((object)entity1 == null || (object)entity2 == null)
                return false;
            if (entity1.Id.ToString() == entity2.Id.ToString())
                return true;
            return false;
        }

        public static bool operator !=(EntityBase<IdType> entity1, EntityBase<IdType> entity2)
        {
            return (!(entity1 == entity2));
        }
    }
}
