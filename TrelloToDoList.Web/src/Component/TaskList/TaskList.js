import React from 'react';
import './TaskList.css';
import Task from '../Task/Task';

// TODO: display tasks from array

class TaskList extends React.Component {
  render() {
      return ( 
        <div class="taks-list">
          <Task name="first"></Task>
          <Task name="second"></Task>
          <Task name="third"></Task>
        </div>);
  }
}

export default TaskList;
