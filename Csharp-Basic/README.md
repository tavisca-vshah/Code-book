
## CSharp-Basic 

### Async Await
- Async await are markers which mark code positions from where control should resume after a task(thread) completes. Await also blocks the control and resume when subtask is completed
- Asynchronous code does not use thread another that main thread. Async keyword does not spawn new thread at background.
- Question: If asyncronous code does not spawn new thread, how does it does? 
  - Answer: The hidden recipe is state Machine, which divides whole code into several chunks, the code is basically schronous but because of state machine, it looks like asynchronous. <br/><br/>
  - ![image](https://user-images.githubusercontent.com/51902571/141487898-fbeb7cb0-1562-4ccd-9746-631810e33010.png) <br/><br/>
  -![image](https://user-images.githubusercontent.com/51902571/141487800-8cac9675-5759-42a3-96c7-45975df117c7.png)
  ![image](https://user-images.githubusercontent.com/51902571/141489655-9d5d4c46-4eb7-4c4c-8412-2d40f0a2d8b4.png)

- Summary: 
- ![image](https://user-images.githubusercontent.com/51902571/141489546-819ea854-b961-4b9d-88fc-27f03cc02158.png)



### Concurrent vs Parallelism
- Concurrent(Context switching, time slicing, shared, making application usable with non blocking without thinking of performance) while Parallel is isolated, dependent.
- Choosing Parallelism where sharing data, chatty nature results in bad design. Concurrent design individual units can be bad design for parallelism
- layman example, tead lead playing role of delivery manager also is concurrent but having appointing manager for this work
- Check difference in table<br/><br/>
  ![concurrent-vs-parallel](https://user-images.githubusercontent.com/51902571/141477019-fbeee552-cfe9-4afc-90c3-5031d2a3b5a3.png)
  
### TPL (Task parallel library)
- Threads are core affinity means once a threads run on one core it will always run on same core.
- As a developer we can write are logic to run threads on different core but you have to smartly select on which core is less loaded also, You are responsible for aggregating final result.
- TPL encapsulate multi core execution.
- TPL does thread pooling


