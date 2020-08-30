## Welcome to my C# Astar pathfinding project 
### This was done using C# forms and a 2D array of Nodes (Inherites from Panels class) as a grid of nodes.
### This project was done as a demo to another project, to test and see how I would implement the path finding algorithm in another project.

- This algorithm is probably not that fast
- It uses a basic priority queue that I came up with. 
- It is a form based project, it dynamically creates panels the form gets initialized. 
- It creates a grid of Nodes, each node is actually just inherited from the panel class, with some of it`s own properties. 
- There is also a debugging console which displays all the valuble properties for each node in the grid. 
- Each node only has a maximum of 4 neighbors, UP, DOWN, LEFT, RIGHT, I have not yet added the diagonal neighbors. 
