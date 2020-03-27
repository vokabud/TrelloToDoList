import React from 'react';
import './MainPage.css';
import UserName from '../UserName/UserName';

class MainPage extends React.Component {
  render() {
      return ( 
        <div class="main-page">
          <h1>
            Trello ToDo List
          </h1>
          <UserName name="User Name"/>
          <div>
            List of tasks;
          </div>
        </div>);
  }
}

export default MainPage;
