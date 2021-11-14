
## CSharp-Basic 

### Async Await
- Async await are markers which mark code positions from where control should resume after a task(thread) completes. Await also blocks the control and resume when subtask is completed
- Asynchronous code does not use thread another that main thread. Async keyword does not spawn new thread at background.
- Question: If asyncronous code does not spawn new thread, how does it does? 
  - Answer: The hidden recipe is state Machine, which divides whole code into several chunks, the code is basically syncronous but because of state machine, it looks like asynchronous. <br/><br/>
  - ``` public static void main(string[] args)
    { 
	    Console.WriteLine("Code 1");
	    Console.WriteLine("Code 2");
	    SomeMethod();
	    Console.WriteLine("Code 7");
	    Console.WriteLine("Code 8");
	    Console.ReadLine();
    }
    private static void SomeMethod()
    { 
	    Console.WriteLine("Code 3");
	    Console.WriteLine("Code 4");
	    await Task.Delay(60000);
	     Console.WriteLine("Code 5");
	    Console.WriteLine("Code 6");
    }
  -![image](https://user-images.githubusercontent.com/51902571/141487800-8cac9675-5759-42a3-96c7-45975df117c7.png)
  ![image](https://user-images.githubusercontent.com/51902571/141489655-9d5d4c46-4eb7-4c4c-8412-2d40f0a2d8b4.png)

- Summary: 
- ![image](https://user-images.githubusercontent.com/51902571/141489546-819ea854-b961-4b9d-88fc-27f03cc02158.png)



### Concurrent vs Parallelism
- Concurrent(Context switching, time slicing, shared, making application usable with non blocking without thinking of performance) while Parallel is isolated, dependent.
- Choosing Parallelism where sharing data, chatty nature results in bad design. Concurrent design individual units can be bad design for parallelism
- layman example, tead lead playing role of delivery manager also is concurrent but having appointing another person to play role of manager for this work is parallelism 
- Check difference in table<br/><br/>


|                      | Concurrent                                                                                        | Parallelism                                |
|----------------------|---------------------------------------------------------------------------------------------------|--------------------------------------------|
| Basic definition     | Executing multiple tasks on the same core using overlapping <br>or time slicing/context switching | Executing multiple tasks on different core |
| Goals                | Make program usable, non blocking                                                                 | Performance                                |
| Resource Utilization | light                                                                                             | Heavy                                      |
| Perspective          | Software design: Composition of independently executing <br>computations in aco-operative fashion | Hardware: Executing computation parallel   |
  
### TPL (Task parallel library)
- Threads are core affinity means once a threads run on one core it will always run on same core.
- As a developer we can write are logic to run threads on different core but you have to smartly select on which core is less loaded also, You are responsible for aggregating final result.
- TPL encapsulate multi core execution.
- TPL does thread pooling

### Static vs singleton
- Singleton = static(global object) + Thread safe + lazy loading + encapsulation + iterator
- Static object can not be passed as parameter as it does not have instance, you cannot do object oriented thing like inheritance, polymorphism
- static class only can contains static data or method


