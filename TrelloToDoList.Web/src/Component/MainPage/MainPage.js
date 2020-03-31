import React from 'react';
import './MainPage.css';
import UserName from '../UserName/UserName';
import TaskList from '../TaskList/TaskList';
import Header from '../Header/Header';

class MainPage extends React.Component {
  render() {
      return ( 
        <div className="page">
          <Header/>
          <main className="content">
            <UserName name="User Name"/>
            <TaskList />
          </main>
        </div>);
  }
}

export default MainPage;
