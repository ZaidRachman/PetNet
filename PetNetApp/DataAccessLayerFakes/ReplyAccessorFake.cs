﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerInterfaces;
using DataObjects;

namespace DataAccessLayerFakes
{
    public class ReplyAccessorFake : IReplyAccessor
    {
        List<ReplyVM> fakeRepliesVM = new List<ReplyVM>();
        List<Reply> fakeReplies = new List<Reply>();
        public ReplyAccessorFake()
        {
            fakeRepliesVM.Add(new ReplyVM
            {
                ReplyId= 1,
                PostId = 1,
                ReplyAuthor = 1,
                ReplyContent = "Post Contents",
                ReplyDate = DateTime.Today,
                ReplyVisibility = true,
                ReplierGivenName = "Gwen",
                ReplierFamilyName = "Arman",
                UserReplyReport = false
            });
            fakeRepliesVM.Add(new ReplyVM
            {
                ReplyId = 2,
                PostId = 1,
                ReplyAuthor = 2,
                ReplyContent = "This is supposed to test what a reply with a very long reply content message would look like. Hopefully this is displayed in a nice clean manner. Otherwise, Gwen will need to fix that because an ugly" +
                "reply is no bueno. If it is displayed well, good job Gwen.. aka myself. Nice Nice Nice Nice",
                ReplyDate = DateTime.Today,
                ReplyVisibility = true,
                ReplierGivenName = "Xander",
                ReplierFamilyName = "Arman",
                UserReplyReport = false
            });
            fakeRepliesVM.Add(new ReplyVM
            {
                ReplyId = 3,
                PostId = 2,
                ReplyAuthor = 1,
                ReplyContent = "Post Contents",
                ReplyDate = DateTime.Today,
                ReplyVisibility = false,
                ReplierGivenName = "Gwen",
                ReplierFamilyName = "Arman",
                UserReplyReport = false
            });
            fakeRepliesVM.Add(new ReplyVM
            {
                ReplyId = 4,
                PostId = 2,
                ReplyAuthor = 1,
                ReplyContent = "Post Contents",
                ReplyDate = DateTime.Today,
                ReplyVisibility = true,
                ReplierGivenName = "Gwen",
                ReplierFamilyName = "Arman",
                UserReplyReport = false
            });
        }

        public int InsertReply(Reply reply)
        {
            int result = 0;
            fakeReplies.Add(reply);

            foreach (var item in fakeReplies)
            {
                if(item.ReplyId == reply.ReplyId)
                {
                    result = 1;
                }
            }
            return result;
        }

        public List<ReplyVM> SelectActiveRepliesByPostId(int postId)
        {
            return fakeRepliesVM.Where(r => r.ReplyVisibility == true && r.PostId == postId).ToList();
        }

        public List<ReplyVM> SelectAllRepliesByPostId(int postId)
        {
            return fakeRepliesVM.Where(r => r.PostId == postId).ToList();
        }

        public int SelectCountActiveRepliesByPostId(int postId)
        {
            return fakeRepliesVM.Where(r => r.PostId == postId && r.ReplyVisibility == true).Count();
        }

        public int SelectCountRepliesByPostId(int postId)
        {
            return fakeRepliesVM.Where(r => r.PostId == postId).Count();
        }

        public ReplyVM SelectReplyByReplyId(int replyId)
        {
            return fakeRepliesVM.Find(r => r.ReplyId == replyId);
        }

        public int UpdateReply(Reply reply, Reply newReply)
        {
            int result = 0;
            foreach (var item in fakeRepliesVM)
            {
                if (item.ReplyId == reply.ReplyId)
                {
                    reply.ReplyContent = newReply.ReplyContent;
                    reply.ReplyDate = newReply.ReplyDate;
                    result = 1;
                }
            }
            return result;
        }
    }
}