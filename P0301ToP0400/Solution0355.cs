using System;
using System.Collections.Generic;

namespace P0301ToP0400
{
    /// <summary>
    /// 355. Design Twitter
    /// </summary>
    public class Solution0355
    {
        public Solution0355()
        {
            Twitter twitter = new Twitter();
            //twitter.PostTweet(1, 5);
            //Write(twitter.GetNewsFeed(1));
            //twitter.Follow(1, 2);
            //twitter.PostTweet(2, 6);
            //Write(twitter.GetNewsFeed(1));
            //twitter.Unfollow(1, 2);
            //Write(twitter.GetNewsFeed(1));

            //twitter.PostTweet(1, 1);
            //Write(twitter.GetNewsFeed(1));
            //twitter.Follow(2, 1);
            //Write(twitter.GetNewsFeed(2));
            //twitter.Unfollow(2, 1);
            //Write(twitter.GetNewsFeed(2));

            Write(twitter.GetNewsFeed(1));

            Console.ReadKey();
        }

        void Write(IList<int> list)
        {            
            foreach (var item in list)
                Console.Write($"{item}  ");
            Console.WriteLine();
        }
    }

    public class Twitter
    {
        /// <summary>
        /// UserList
        /// </summary>
        public List<TwitterUser> UserList;

        /// <summary>
        /// TwitterList
        /// </summary>
        public List<TwitterInfo> TwitterList;

        #region 构造函数
        /// <summary>
        /// Initialize your data structure here.
        /// </summary>
        public Twitter()
        {
            UserList = new List<TwitterUser>();
            TwitterList = new List<TwitterInfo>() { new TwitterInfo() { poster = 1, twitterIndex = 1 } };
            TwitterList.RemoveAt(0);
        }
        #endregion

        #region PostTweet
        /// <summary>
        /// Compose a new tweet.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="tweetId"></param>
        public void PostTweet(int userId, int tweetId)
        {
            if (!IsUserExists(userId))
                UserList.Add(new TwitterUser() { id = userId });
            TwitterList.Add(new TwitterInfo() { poster = userId, twitterIndex = tweetId });
        }
        #endregion

        #region GetNewsFeed
        /// <summary>
        /// Retrieve the 10 most recent tweet ids in the user's news feed. Each item in the news feed must be posted by users who the user followed or by the user herself. Tweets must be ordered from most recent to least recent.
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public IList<int> GetNewsFeed(int userId)
        {
            if (TwitterList == null)
                return null;
            int index = TwitterList.Count;
            int twitterCount = 0;
            if (!IsUserExists(userId))
                return null;
            IList<int> newsList = new List<int>();
            List<int> followeeList = new List<int>();
            foreach (TwitterUser twitterUser in UserList)
                if (twitterUser.id == userId)
                    followeeList = twitterUser.followeeID;
            while (index > 0 && twitterCount < 10)
            {
                if (TwitterList[index - 1].poster == userId || (followeeList != null && followeeList.Contains(TwitterList[index - 1].poster)))
                {
                    newsList.Add(TwitterList[index - 1].twitterIndex);
                    twitterCount++;
                }
                index--;
            }
            return newsList;
        }
        #endregion

        #region Follow
        /// <summary>
        /// Follower follows a followee. If the operation is invalid, it should be a no-op.
        /// </summary>
        /// <param name="followerId"></param>
        /// <param name="followeeId"></param>
        public void Follow(int followerId, int followeeId)
        {
            if (!IsUserExists(followerId))
                UserList.Add(new TwitterUser() { id = followerId });
            if (!IsUserExists(followeeId))
                UserList.Add(new TwitterUser() { id = followeeId });
            if (UserList.Count == 0)
                return;
            if (IsFollowed(followerId, followeeId))
                return;
            foreach (TwitterUser twitterUser in UserList)
                if (twitterUser.id == followerId)
                    twitterUser.followeeID.Add(followeeId);
        }
        #endregion

        #region Unfollow
        /// <summary>
        /// Follower unfollows a followee. If the operation is invalid, it should be a no-op. 
        /// </summary>
        /// <param name="followerId"></param>
        /// <param name="followeeId"></param>
        public void Unfollow(int followerId, int followeeId)
        {
            if (UserList == null)
                return;
            if (UserList.Count == 1 || !IsUserExists(followerId) || !IsUserExists(followeeId))
                return;
            foreach (TwitterUser twitterUser in UserList)
                if (twitterUser.id == followerId)
                    twitterUser.followeeID.Remove(followeeId);
        }
        #endregion

        #region IsFollowed
        /// <summary>
        /// Is Follower follows followee
        /// </summary>
        /// <param name="user"></param>
        /// <param name="followeeId"></param>
        /// <returns></returns>
        private bool IsFollowed(int user, int followeeId)
        {
            if (UserList.Count == 0)
                return false;
            List<int> followees = new List<int>();
            foreach (TwitterUser twitterUser in UserList)
            {
                if (twitterUser.id == user)
                {
                    followees = twitterUser.followeeID;
                    break;
                }
            }
            if (followees == null)
                return false;
            foreach (int followee in followees)
                if (followee == followeeId)
                    return true;
            return false;
        }
        #endregion

        #region IsUserExists
        /// <summary>
        /// Is Twitter user exists
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        private bool IsUserExists(int user)
        {
            if (UserList.Count == 0)
                return false;
            foreach (TwitterUser twitterUser in UserList)
                if (twitterUser.id == user)
                    return true;
            return false;
        }
        #endregion
    }
    public class TwitterUser
    {
        public int id;
        public List<int> followeeID = new List<int>();
    }
    public struct TwitterInfo
    {
        public int poster;
        public int twitterIndex;
    }
}
