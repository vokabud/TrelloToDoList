import React from 'react';
import { render } from '@testing-library/react';
import MainPage from './MainPage';

test('renders learn react link', () => {
  const { getByText } = render(<MainPage />);
  const linkElement = getByText(/Trello ToDo List/i);
  expect(linkElement).toBeInTheDocument();
});
