namespace FakeItExtensibly;

using System.Linq.Expressions;
using FakeItEasy;
using FakeItEasy.Configuration;
using FakeItEasy.Creation;

/// <inheritdoc cref="A"/>
public sealed class SomeKeyword
{
    internal SomeKeyword()
    {
    }

    public static SomeKeyword Some { get; } = new();

    /// <inheritdoc cref="A.Fake{T}"/>
    public T Fake<T>()
        where T : class =>
        A.Fake<T>();

    /// <inheritdoc cref="A.Fake{T}(Action{IFakeOptions{T}})"/>
    public T Fake<T>(Action<IFakeOptions<T>> optionsBuilder)
        where T : class =>
        A.Fake<T>(optionsBuilder);

    /// <inheritdoc cref="A.CollectionOfFake{T}(int)"/>
    public IList<T> CollectionOfFake<T>(int numberOfFakes)
        where T : class =>
        A.CollectionOfFake<T>(numberOfFakes);

    /// <inheritdoc cref="A.CollectionOfFake{T}(int, Action{IFakeOptions{T}})"/>
    public IList<T> CollectionOfFake<T>(int numberOfFakes, Action<IFakeOptions<T>> optionsBuilder)
        where T : class =>
        A.CollectionOfFake<T>(numberOfFakes, optionsBuilder);

    /// <inheritdoc cref="A.CollectionOfFake{T}(int, Action{IFakeOptions{T}, int})"/>
    public IList<T> CollectionOfFake<T>(int numberOfFakes, Action<IFakeOptions<T>, int> optionsBuilder)
        where T : class =>
        A.CollectionOfFake<T>(numberOfFakes, optionsBuilder);

    /// <inheritdoc cref="A.Dummy{T}"/>
    public T Dummy<T>() =>
        A.Dummy<T>();

    /// <inheritdoc cref="A.CollectionOfDummy{T}(int)"/>
    public IList<T> CollectionOfDummy<T>(int numberOfDummies) =>
        A.CollectionOfDummy<T>(numberOfDummies);

    /// <inheritdoc cref="A.CallTo(Expression{Action})"/>
    public IVoidArgumentValidationConfiguration CallTo(Expression<Action> callSpecification) =>
        A.CallTo(callSpecification);

    /// <inheritdoc cref="A.CallTo(object)"/>
    public IAnyCallConfigurationWithNoReturnTypeSpecified CallTo(object fake) =>
        A.CallTo(fake);

    /// <inheritdoc cref="A.CallTo{T}(Expression{Func{T}})"/>
    public IReturnValueArgumentValidationConfiguration<T> CallTo<T>(Expression<Func<T>> callSpecification) =>
        A.CallTo(callSpecification);

    /// <inheritdoc cref="A.CallToSet{TValue}(Expression{Func{TValue}})"/>
    public IPropertySetterAnyValueConfiguration<TValue> CallToSet<TValue>(Expression<Func<TValue>> propertySpecification) =>
        A.CallToSet(propertySpecification);

    /// <inheritdoc cref="A.CallTo(object, EventAction)"/>
    public IAnyCallConfigurationWithVoidReturnType CallTo(object fake, EventAction action) =>
        A.CallTo(fake, action);
}
