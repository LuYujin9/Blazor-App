# Gantt

- no columns on the right side
- separation line for grouping not possible
- no multiple tasks in one record possible

# Calender

- Column Header cannot be above grouping
- Labels on the left side need to be hidden
- no columns on the right side

# Data grid

- table does not allow cells spanning multiple columns

# Style

- after choosing filter and sort, the context can be 省略, should they 动态, or the width is the same as longest option?
- the border between the 'last active' and the first 'date cell' should be a full line?
- the border radius at the left-top 角 should be round?
-
-

# TO DO

- style the date cell, when it is 'today'
- style table-row.table-header border radius
- style the width of appointment box, that it changes with the width of DateBlock
- style the color of team row
- table overflow:scroll
- find a better way to style table-container border radius
- make the border of table better
- change some class name
- add a color to the frame of appointment box

# Questions

- changed the position of date from last active, is it ok?
- can the filter of company and users without the count of options?
- when there is appointment in dateBlock, does the background have to be set to white? it looks not so good, when only the background color changed in the first date block.
- can I remove the lines in team row?
- edit button without border? which one looks better?

- what is the better way to organize the css files and component? 我觉得不要怕重复, 应该分开, 谁更优先呢? 如果都是同样的 Selector Specificity, 谁会在后面? component?
