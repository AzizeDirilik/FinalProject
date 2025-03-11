using Castle.DynamicProxy;
using System.Reflection;

namespace Core.Utilities.Interceptors
{

    public class AspectInterceptorSelector : IInterceptorSelector
{
    public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
    {
        var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true).ToList();

        // Arayüz durumunu kontrol et
        if (type.IsInterface)
        {
            type = method.DeclaringType;
        }

        // BindingFlags ile metodu al
        var methodInfo = type.GetMethod(method.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, method.GetParameters().Select(p => p.ParameterType).ToArray(), null);

        if (methodInfo != null)
        {
            var methodAttributes = methodInfo.GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
        }


        return classAttributes.OrderBy(x => x.Priority).ToArray();
    }
}

}
