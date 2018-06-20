# Inheritance

## Abstract



## Inheritance

Derived classes

## Override

`override` keyword

Derived classes can also override inherited members by providing an alternate
implementation. In order to be able to override a member, the member in the base
class must be marked with the virtual keyword. By default, base class members
are not marked as virtual and cannot be overridden. Attempting to override a
non-virtual member, as the following example does, generates compiler error
CS0506: " cannot override inherited member because it is not marked virtual,
abstract, or override.

## Private

Private members are visible only in derived classes that are nested in their
base class.

## Public

Shows a basic example of inheritance.

Public members are visible in derived classes and are part of the derived class'
public interface. Public inherited members can be called just as if they were
defined in the derived class. In the following example, class A defines a method
named Method1, and class B inherits from class A. The example then calls Method1
as if it were an instance method on B.
