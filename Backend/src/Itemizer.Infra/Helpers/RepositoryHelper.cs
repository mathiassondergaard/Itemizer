using Itemizer.Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Itemizer.Infra.Helpers;
public static class RepositoryHelper
{
    // Helper function for handling multiple predicates
    public static IQueryable<TEntity> WhereAny<TEntity>(this IQueryable<TEntity> source, IEnumerable<Expression<Func<TEntity, bool>>> predicates) where TEntity : class
    {
        if (predicates != null && predicates.Any())
        {
            if (predicates.Count() == 1)
            {
                return source.Where(predicates.First());
            }
            foreach (var predicate in predicates)
            {
                source = source.Where(predicate);
            }
        }

        return source;
    }

    // Helper function for handling multiple entities to be included
    public static IQueryable<TEntity> IncludeEntities<TEntity>(this IQueryable<TEntity> source, IEnumerable<String> includedEntities) where TEntity : class
    {
        if (includedEntities != null && includedEntities.Any())
        {
            if (includedEntities.Count() == 1)
            {
                return source.Include(includedEntities.First());
            }
            foreach (var entity in includedEntities)
            {
                source = source.Include(entity);
            }
        }

        return source;
    }
}
