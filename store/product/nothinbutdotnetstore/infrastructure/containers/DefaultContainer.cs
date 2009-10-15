using System;
using System.Collections.Generic;
using developwithpassion.commons.core.infrastructure.containers;

namespace nothinbutdotnetstore.infrastructure.containers
{
    public class DefaultContainer : Container
    {
        ContainerItemFactoryRegistry registry;

        public DefaultContainer(ContainerItemFactoryRegistry registry)
        {
            this.registry = registry;
        }

        public Dependency instance_of<Dependency>()
        {
            return (Dependency) instance_of(typeof (Dependency));
        }

        public object instance_of(Type dependency_type)
        {
            try
            {
                return registry.get_resolution_item_for(dependency_type).create();
            }
            catch (Exception exception)
            {
                throw new ContainerItemResolutionException(exception, dependency_type);
            }
        }

        public IEnumerable<DependencyType> all_instances_of<DependencyType>()
        {
            throw new NotImplementedException();
        }
    }
}