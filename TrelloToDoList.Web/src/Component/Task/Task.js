import React from 'react';
import './Task.css';

// TODO: change state of marked tasks

class Task extends React.Component {
  render() {
      return ( 
        <div class="task">
          <input type="checkbox" />
          <span class="task-name">
            {this.props.name}
          </span>
        </div>);
  }
}

export default Task;
