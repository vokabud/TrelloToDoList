import React from 'react';
import './Task.css';

// TODO: change state of marked tasks

class Task extends React.Component {
  constructor(props) {
    super(props);
    this.state = { marked: false };

    this.toggle = this.toggle.bind(this);
  }

  toggle() {
    var currentState = this.state.marked;
    this.setState({ marked: !currentState});
  }

  render() {
      return (
        <div className={this.state.marked ? "task marked" : "task"}>
          <input type="checkbox" onClick={this.toggle}/>
          <span className="task-name">
            {this.props.name}
          </span>
        </div>);
  }
}

export default Task;
