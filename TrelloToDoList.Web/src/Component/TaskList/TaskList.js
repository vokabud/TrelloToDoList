import React from 'react';
import './TaskList.css';
import Task from '../Task/Task';

const taskList = [ // TODO: set state in componentWillMount()
  { id: "1", name: "First"},
  { id: "2", name: "Second"},
  { id: "3", name: "Third"},
  { id: "4", name: "Fourth"},
];

class TaskList extends React.Component {
  render() {
      return (
        <div className="taks-list">
          {
            taskList.map(function(item) {
              return <Task key={item.id} name={item.name}/>
            })
          }
        </div>);
  };
}

export default TaskList;
