import React from 'react';
import './MainPage.css';
import UserName from '../UserName/UserName';
import TaskList from '../TaskList/TaskList';

class MainPage extends React.Component {
  render() {
      return ( 
        <div class="main-page">
          <h1>
            Trello ToDo List
          </h1>
          <UserName name="User Name"/>
          <TaskList />
        </div>);
  }
}

export default MainPage;
