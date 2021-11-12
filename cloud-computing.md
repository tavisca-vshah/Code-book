## Cloud Computing/ Infrastructure
### Horizontal vs vertical Scaling
Horizontal scaling in cloud computing means adding additional instances instead of moving to a larger instance size.
Vertical scaling refers to adding more or faster CPUs, memory, or I/O resources to an existing server, 
or replacing one server with a more powerful server
### ECS vs EC2
ECS is just about clustering of EC2 instances, and 
uses Docker to instantiate containers/instances/virtual machines on these (EC2) hosts.

### Apache Casandra
- Apache Cassandra is an open source NoSQL distributed database trusted by thousands of companies for scalability and high availability without compromising performance. 
- Linear scalability and proven fault-tolerance on commodity hardware or cloud infrastructure make it the perfect platform for mission-critical data.
- It is scalable, fault-tolerant, and consistent.
- It is a column-oriented database.
- Its distribution design is based on Amazon’s Dynamo and its data model on Google’s Bigtable.
- Created at Facebook, it differs sharply from relational database management systems.
- Cassandra implements a Dynamo-style replication model with no single point of failure, but adds a more powerful “column family” data model.
#### Features of Cassandra
Cassandra has become so popular because of its outstanding technical features. 
Given below are some of the features of Cassandra:
- Elastic scalability − Cassandra is highly scalable; it allows to add more hardware to 
accommodate more customers and more data as per requirement.
- Always on architecture − Cassandra has no single point of failure and it is continuously available for business-critical applications that cannot afford a failure.
- Fast linear-scale performance − Cassandra is linearly scalable, i.e., it increases your throughput as you increase the number of nodes in the cluster. 
- Therefore it maintains a quick response time.
- Flexible data storage − Cassandra accommodates all possible data formats including: structured, semi-structured, and unstructured. 
- It can dynamically accommodate changes to your data structures according to your need.
- Easy data distribution − Cassandra provides the flexibility to distribute data where you need by replicating data across multiple data centers.
- Transaction support − Cassandra supports properties like Atomicity, Consistency, Isolation, and Durability (ACID).
- Fast writes − Cassandra was designed to run on cheap commodity hardware. It performs blazingly fast writes and can store hundreds of terabytes of data, 
without sacrificing the read efficiency.
