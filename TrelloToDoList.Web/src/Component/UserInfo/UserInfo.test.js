import React from 'react';
import { render } from '@testing-library/react';
import UserInfo from './UserInfo';

test('renders learn react link', () => {
  const { getByText } = render(<UserInfo name="name"/>);
  const linkElement = getByText(/name/i);
  expect(linkElement).toBeInTheDocument();
});
