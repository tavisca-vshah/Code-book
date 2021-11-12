

## Objects oriented programming

### Encapsulation VS Abstraction
 - Encapsulation always means the data is hiding and controlling
    access, while abstraction means generalizing the objects.<br/><br/>
 - Encapsulation solves the problem in the implementation level, while Abstraction solves the problem in the design level.<br/><br/>
 - While Encapsulation is implemenentation technique to encapsulate into unit called **Class**, while Abstraction is basically a way to think moreover sky level view.<br/><br/>
###  Abstract vs Interfaces

 - Interfaces are contract, while abstract class is half/partial implemented class.<br/><br/>
 - Interfaces are implemented while abstract class is inherited.<br/><br/>
 - Interface helps to identify abstraction.<br/><br/>
 - Multiple inheritance is not achieved by abstract class, while It is achieved by interface<br/><br/>
 - Interface helps to identify abstraction.(Plan the abstraction without worrying about implementation).<br/><br/>
 - Abstract class can be pulled to make it looks like a interfaces, but somwhere down the line you can have design issue. like multiple inheritance.
    
  #### When to use interface vs Abstract
 -  If many implementations are of the same kind and use common behavior, then it is superior to use abstract class. If many implementations only share methods, then it is     superior to use Interface.
 - If you want to achieve multiple inheritance.

###  Abstract vs Virtual

 - Virtual methods have an implementation and provide the derived classes with the option of overriding it. 
 - Abstract methods do not provide an implementation and force the derived classes to override the method.
 - So, Abstract methods have no actual code in them, and subclasses HAVE TO override the method. 
	Virtual methods can have code, which is usually a default implementation of something, and any subclasses CAN override the method using the override modifier and provide a custom implementation.
    ```
    
	    public abstract class E
	    {
	        public abstract void AbstractMethod(int i);

	        public virtual void VirtualMethod(int i)
	        {
	            // Default implementation which can be overridden by subclasses.
	        }
	    }

	    public class D : E
	    {
	        public override void AbstractMethod(int i)
	        {
	            // You HAVE to override this method
	        }
	        public override void VirtualMethod(int i)
	        {
	            // You are allowed to override this method.
	        }
	    }
