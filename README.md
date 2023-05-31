# What I did
1.Created SQL Store Procedure with recursion for the Properties table<br>
  &ensp;&ensp;-Made recursion from parentId column to Id column<br>
  &ensp;&ensp;-Select the necessary column and store the query in procedure 

2.Setting up the API route<br>
  &ensp;&ensp;-Made Export endpoint, type GET<br>
  &ensp;&ensp;-Connect to the DB from the Export endpoint and call the store procedure<br>
  &ensp;&ensp;-Store the response from the DB
  
3.Tree structure<br>
  &ensp;&ensp;-Made a simple Node class with all the properties from the DB response<br>
  &ensp;&ensp;-And created a fucntion to add all the child Nodes to their parent Nodes
  
4.Display the data<br>
  &ensp;&ensp;-Call the endpoint from the frontend and deserialize the response<br>
  &ensp;&ensp;-Create reusable component with the @helper and loop through the response<br>
  &ensp;&ensp;-Format the data in plain text and raw html
