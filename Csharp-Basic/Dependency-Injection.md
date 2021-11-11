<h6> Dependency Injection <h6>

1. What is need of DI?
Ans: DI is a design methodology where in rather than caller creating the instance, 
its injected by some framework or some other mechanism.
2. Explain the IOC?
Ans: Inversion of control is a principle where we say focus on your work and other tasks delegated to somework else.
3. Benefit of DI
ans : DI helps to implement decoupled architecture where you change at one place and changes are reflected at many places.
Whole goal of DI is good architecture and what is good architecture is decoupled architecture where you change at minimal place 
and it is reflected at all places.


Scope vs transient vs singleton 
Ans: Define the lifetime of DI object.

Singleton:
Only one instace of object is created for the whole web application.
Scoped:
1. For every request new instace will be injected.
2. In same request if we DI multiple times same instace is injected.

Transient:
1. For every request new instace will be injected.
2. In same request if we DI multiple times different instace is injected.

When you use what:
Singleton
1. Caching,
2. HitCounter
3. Shared services

Scoped:
Repository for same transaction, Business Object,used most of time. same commit and same rollback
transient:
1. Instance should not affect each other like different transaction, thread safety as objects are different instances. 
Same object asked multiple times in the constructor. different commit and different rollback
